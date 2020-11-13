using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris : Form
    {
        private string filePath;
        List<(List<Polymino> polyminos, ProblemType problemType, AlgorithmType algorithmType)> tasks;
        List<Polymino> pentominos;
        ProblemType currentProblemType = ProblemType.Square;
        AlgorithmType currentAlgorithmType = AlgorithmType.Precise;

        public Tetris()
        {
            InitializeComponent();
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
            // Generowanie klockow
            pentominos = new List<Polymino>();
            if (loadFromFileRadio.Checked)
            {
                // zahardkodowane branie tylko jednego zadania na razie
                try
                {
                    tasks = await FileReader.LoadPolyminosFromFileAsync(filePath);
                    (pentominos, currentProblemType, currentAlgorithmType) = tasks[0];
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                GenerateRandomPentominos();
            // TODO: wyswietlic liste w GUI i zrobic cos z Pentominos

            textBox1.Text = pentominos.Where(p => p.Type == Types.F).Count().ToString();
            textBox2.Text = pentominos.Where(p => p.Type == Types.FF).Count().ToString();
            textBox3.Text = pentominos.Where(p => p.Type == Types.I).Count().ToString();
            textBox4.Text = pentominos.Where(p => p.Type == Types.L).Count().ToString();
            textBox5.Text = pentominos.Where(p => p.Type == Types.LL).Count().ToString();
            textBox6.Text = pentominos.Where(p => p.Type == Types.N).Count().ToString();
            textBox7.Text = pentominos.Where(p => p.Type == Types.NN).Count().ToString();
            textBox8.Text = pentominos.Where(p => p.Type == Types.P).Count().ToString();
            textBox9.Text = pentominos.Where(p => p.Type == Types.PP).Count().ToString();
            textBox10.Text = pentominos.Where(p => p.Type == Types.T).Count().ToString();
            textBox11.Text = pentominos.Where(p => p.Type == Types.U).Count().ToString();
            textBox12.Text = pentominos.Where(p => p.Type == Types.V).Count().ToString();
            textBox13.Text = pentominos.Where(p => p.Type == Types.W).Count().ToString();
            textBox14.Text = pentominos.Where(p => p.Type == Types.X).Count().ToString();
            textBox15.Text = pentominos.Where(p => p.Type == Types.Y).Count().ToString();
            textBox16.Text = pentominos.Where(p => p.Type == Types.YY).Count().ToString();
            textBox17.Text = pentominos.Where(p => p.Type == Types.Z).Count().ToString();
            textBox18.Text = pentominos.Where(p => p.Type == Types.ZZ).Count().ToString();

            panel1.Visible = true;

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
                pentominos.Add(new Polymino((Types)pentomino));
            }
        }

        private async void solveButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            List<Board> boardSolutions = null;
            int? cuttings = null;
            await Task.Run(() => (boardSolutions, cuttings) = Solver.Solve(currentProblemType, currentAlgorithmType, pentominos));
            (sender as Button).Enabled = true;
            ShowSolution(boardSolutions, cuttings);
        }

        private void ShowSolution(List<Board> solutions, int? cuttings)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();


            tableLayoutPanel1.Visible = true;
            var textBoxArray = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18 };
            pictureBox1.Visible = false;
            foreach (var textBox in textBoxArray)
                textBox.Visible = false;

            if (solutions == null || solutions[0] == null)
                return;

            tableLayoutPanel1.ColumnCount = solutions[0].Fields.GetLength(0);
            tableLayoutPanel1.RowCount = solutions[0].Fields.GetLength(1);

            var mappedColors = GetMappedColors(solutions[0]);


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
                        BackColor = mappedColors[solutions[0].Fields[i, j].id]
                    };
                    tableLayoutPanel1.Controls.Add(pB, i, j);
                }
            }
        }

        public Dictionary<int, Color> GetMappedColors(Board solution)
        {
            Dictionary<int, Color> idToColor = new Dictionary<int, Color>();
            //ładne kolorki
            idToColor.Add(0, Color.FromArgb(255, 255, 255));
            idToColor.Add(1, Color.FromArgb(249, 65, 68));
            idToColor.Add(2, Color.FromArgb(243, 114, 44));
            idToColor.Add(3, Color.FromArgb(248, 150, 30));
            idToColor.Add(4, Color.FromArgb(249, 132, 74));
            idToColor.Add(5, Color.FromArgb(249, 199, 79));
            idToColor.Add(6, Color.FromArgb(144, 190, 109));
            idToColor.Add(7, Color.FromArgb(67, 170, 139));
            idToColor.Add(8, Color.FromArgb(77, 144, 142));
            idToColor.Add(9, Color.FromArgb(87, 117, 144));
            idToColor.Add(10, Color.FromArgb(39, 125, 161));

            //Random r = new Random();

            //for (int i = 0; i < solution.Fields.GetLength(0); i++)
            //{
            //    for (int j = 0; j < solution.Fields.GetLength(1); j++)
            //    {
            //        var tempId = solution.Fields[i, j].id;
            //        if (!idToColor.ContainsKey(tempId))
            //        {
            //            idToColor[tempId] = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            //        }
            //    }
            //}
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
    }
}
