using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris : Form
    {
        private readonly List<TextBox> textboxes = new List<TextBox>();
        private string filePath;
        List<(List<Polymino> polyminos, ProblemType problemType, AlgorithmType algorithmType)> tasks;
        List<Polymino> pentominos;
        ProblemType currentProblemType = ProblemType.Square;
        AlgorithmType currentAlgorithmType = AlgorithmType.Precise;
        List<Board> boardSolutions = null;
        int? cuttings = null;
        long elapsed = 0;
        private int currentTaskIndex = 0;
        private int solutionsLimit = 10;

        public Tetris()
        {
            InitializeComponent();
            limitSolutionsCheckbox.Checked = true;
            textboxes = new List<TextBox>()
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6,
                textBox7, textBox8, textBox9, textBox10, textBox11, textBox12,
                textBox13, textBox14, textBox15, textBox16, textBox17, textBox18
            };
        }

        private void loadFromFileRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (loadFromFileRadio.Checked)
            {
                pentominoCounter.Enabled = false;
                if (filePath != null && filePath.Length > 0)
                    startButton.Enabled = true;
                else
                    startButton.Enabled = false;
            }
            else
            {
                pentominoCounter.Enabled = true;
                startButton.Enabled = true;
                currentAlgorithmType = accurateRadio.Checked
                    ? AlgorithmType.Precise
                    : AlgorithmType.Heuristic;

                currentProblemType = squareRadio.Checked
                    ? ProblemType.Square
                    : ProblemType.Rectangle;
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            HideSolutionControlls();
            // Generowanie klockow
            pentominos = new List<Polymino>();

            if (loadFromFileRadio.Checked)
            {
                // zahardkodowane branie tylko jednego zadania na razie
                try
                {
                    tasks = await FileReader.LoadPolyminosFromFileAsync(filePath);
                    (pentominos, currentProblemType, currentAlgorithmType) = tasks[0];
                    currentTaskIndex = 0;
                    FillPentominostextboxes();
                    UpdateAlgorithmAndProblemRadiosAccordingToTaskFromFile();
                    UpdateTasksFromFileLabel();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (randomRadio.Checked)
            {
                GenerateRandomPentominos();
                FillPentominostextboxes();
            }
            else if (keyboardRadio.Checked)
            {
                foreach (var textbox in textboxes)
                {
                    if (textbox.Text == null || textbox.Text == "")
                        textbox.Text = "0";
                }
            }

            panel1.Visible = true;
            SolutionView.Visible = false;
            solveButton.Enabled = true;
            nextTaskButton.Enabled = ShouldNextTaskBeEnabled();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                filePathTextBox.Text = filePath;
                startButton.Enabled = true;
            }
        }

        private void GenerateRandomPentominos()
        {
            var random = new Random();
            for (int i = 0; i < pentominoCounter.Value; i++)
            {
                var pentomino = random.Next(1, 18);
                pentominos.Add(new Polymino((Types)pentomino, i+1));
            }
        }

        private async void solveButton_Click(object sender, EventArgs e)
        {
            await solveAlgorithm();
        }

        private async Task solveAlgorithm()
        {
            int id = 1;
            pentominos = new List<Polymino>();
            for (int i = 0; i < textboxes.Count; i++)
            {
                if (!int.TryParse(textboxes[i].Text, out var count))
                    count = 0;
                for (int j = 0; j < count; j++)
                {
                    pentominos.Add(new Polymino((Types)(i + 1), id));
                    id++;
                }
            }

            solveButton.Enabled = false;
            startButton.Enabled = false;
            nextTaskButton.Enabled = false;

            processingLabel.Visible = true;
            var watch = new Stopwatch();
            watch.Start();
            await Task.Run(() => (boardSolutions, cuttings) = Solver.Solve(currentProblemType, currentAlgorithmType, pentominos, solutionsLimit));
            watch.Stop();
            elapsed = watch.ElapsedMilliseconds;
            processingLabel.Visible = false;
            solveButton.Enabled = true;
            startButton.Enabled = true;
            nextTaskButton.Enabled = ShouldNextTaskBeEnabled();
            ShowSolution(0);
            UpdateTasksFromFileLabel();
        }

        private void ShowSolution(int solutionInd)
        {
            panel1.Visible = false;
            SolutionView.Visible = true;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.Visible = true;
            panel1.Visible = false;

            #region Solution Selection
            solutionsLabel.Text = "Solution               of " + boardSolutions.Count;
            //solutionCounter.Value = 1;
            solutionCounter.Minimum = 1;
            if (currentAlgorithmType == AlgorithmType.Heuristic) // dla heurystycznego blokujemy wybranie rozwiazania
            {
                solutionCounter.Enabled = false;
            }
            else
            {
                solutionCounter.Maximum = boardSolutions.Count;
                solutionCounter.Enabled = true;
            }
            #endregion

            #region Timer
            int secs = (int)(elapsed / 1000);
            int milisecs = (int)(elapsed % 1000);
            string mili = milisecs.ToString();
            if (milisecs < 10)
                mili = "00" + milisecs;
            else if (milisecs < 100)
                mili = "0" + milisecs;
            elapsedTime.Text = "Elapsed time: " + secs + "." + mili + "s";
            #endregion

            #region Cuts
            if (cuttings != null && cuttings.HasValue)
            {
                cutsLabel.Visible = true;
                cutsLabel.Text = "Cuts: " + cuttings.Value;
            }
            else
            {
                cutsLabel.Visible = false;
            }
            #endregion

            if (boardSolutions == null || boardSolutions[0] == null)
                return;

            tableLayoutPanel1.ColumnCount = boardSolutions[solutionInd].Fields.GetLength(0);
            tableLayoutPanel1.RowCount = boardSolutions[solutionInd].Fields.GetLength(1);

            var mappedColors = GetMappedColors(boardSolutions[solutionInd]);


            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100/tableLayoutPanel1.RowCount));
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tableLayoutPanel1.ColumnCount));
                    PictureBox pB = new PictureBox
                    {
                        Size = MaximumSize,
                        Dock = DockStyle.Fill,
                        BackColor = mappedColors[boardSolutions[solutionInd].Fields[j, i].id]
                    };
                    tableLayoutPanel1.Controls.Add(pB, j, i);
                }
            }
        }

        public Dictionary<int, Color> GetMappedColors(Board solution)
        {
            Dictionary<int, Color> idToColor = new Dictionary<int, Color>();
            //background color
            idToColor.Add(0, Color.FromArgb(255, 255, 255));

            Random r = new Random();

            for (int i = 0; i < solution.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < solution.Fields.GetLength(1); j++)
                {
                    var tempId = solution.Fields[i, j].id;
                    if (!idToColor.ContainsKey(tempId))
                    {
                        idToColor[tempId] = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                    }
                }
            }
            return idToColor;
        }
        private void accurateRadio_CheckedChanged(object sender, EventArgs e)
        {
            currentAlgorithmType = (sender as RadioButton).Checked
                ? AlgorithmType.Precise
                : AlgorithmType.Heuristic;
        }

        private void squareRadio_CheckedChanged(object sender, EventArgs e)
        {
            currentProblemType = (sender as RadioButton).Checked
                ? ProblemType.Square
                : ProblemType.Rectangle;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeSolutionButton_Click(object sender, EventArgs e)
        {
            ShowSolution((int)solutionCounter.Value - 1);
        }

        private bool ShouldNextTaskBeEnabled() => loadFromFileRadio.Checked && currentTaskIndex < tasks.Count;

        private void nextTaskButton_Click(object sender, EventArgs e)
        {
            HideSolutionControlls();
            if (!loadFromFileRadio.Checked || ++currentTaskIndex >= tasks?.Count)
            {
                nextTaskButton.Enabled = ShouldNextTaskBeEnabled();
                return;
            }

            (pentominos, currentProblemType, currentAlgorithmType) = tasks[currentTaskIndex];
            FillPentominostextboxes();
            UpdateAlgorithmAndProblemRadiosAccordingToTaskFromFile();
            UpdateTasksFromFileLabel();
        }

        private void HideSolutionControlls()
        {
            panel1.Visible = true;
            SolutionView.Visible = false;
            tableLayoutPanel1.Visible = false;

            solutionCounter.Enabled = false;

            cutsLabel.Visible = true;
        }

        private void FillPentominostextboxes()
        {
            for (int i = 1; i <= 18; i++)
            {
                textboxes[i - 1].Text = pentominos.Where(p => p.Type == (Types)i).Count().ToString();
            }
        }

        private void UpdateAlgorithmAndProblemRadiosAccordingToTaskFromFile()
        {
            accurateRadio.Checked = tasks[currentTaskIndex].algorithmType == AlgorithmType.Precise;
            heuristicRadio.Checked = tasks[currentTaskIndex].algorithmType == AlgorithmType.Heuristic;

            squareRadio.Checked = tasks[currentTaskIndex].problemType == ProblemType.Square;
            rectangleRadio.Checked = tasks[currentTaskIndex].problemType == ProblemType.Rectangle;
        }

        private void UpdateTasksFromFileLabel()
        {
            tasksFromFileaLabel.Text = tasks != null
                ? $"Task {currentTaskIndex + 1} of {tasks.Count}"
                : "No file loaded";
        }

        private void limitSolutionsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSolutionsLimit();
            if (limitSolutionsCheckbox.Checked == false)
                solutionsLimitCounter.Enabled = false;
            else
                solutionsLimitCounter.Enabled = true;
        }
        private void solutionsLimitCounter_ValueChanged(object sender, EventArgs e)
        {
            UpdateSolutionsLimit();
        }

        private void UpdateSolutionsLimit()
        {
            if (limitSolutionsCheckbox.Checked)
            {
                solutionsLimit = (int)solutionsLimitCounter.Value;
            }
            else
            {
                solutionsLimit = int.MaxValue;
            }
        }
    }
}
