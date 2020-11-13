using System;
using System.Collections.Generic;
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

            labelF.Text = pentominos.Where(p => p.Type == Types.F).Count().ToString();
            labelI.Text = pentominos.Where(p => p.Type == Types.I).Count().ToString();
            labelLL.Text = pentominos.Where(p => p.Type == Types.L).Count().ToString();
            labelN.Text = pentominos.Where(p => p.Type == Types.N).Count().ToString();
            labelP.Text = pentominos.Where(p => p.Type == Types.P).Count().ToString();
            labelT.Text = pentominos.Where(p => p.Type == Types.T).Count().ToString();
            labelU.Text = pentominos.Where(p => p.Type == Types.U).Count().ToString();
            labelV.Text = pentominos.Where(p => p.Type == Types.V).Count().ToString();
            labelW.Text = pentominos.Where(p => p.Type == Types.W).Count().ToString();
            labelX.Text = pentominos.Where(p => p.Type == Types.X).Count().ToString();
            labelY.Text = pentominos.Where(p => p.Type == Types.Y).Count().ToString();
            labelZ.Text = pentominos.Where(p => p.Type == Types.Z).Count().ToString();
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
                var pentomino = random.Next(0, 11);
                pentominos.Add(new Polymino((Types)pentomino));
            }
        }

        private void PrintResult(Board board)
        {
            throw new NotImplementedException();
        }

        private async void solveButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            await Task.Run(() => Solver.Solve(currentProblemType, currentAlgorithmType, pentominos));
            (sender as Button).Enabled = true;
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
    }
}
