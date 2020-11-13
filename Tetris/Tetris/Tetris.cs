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

            textBox1.Text = pentominos.Where(p => p.Type == Types.F).Count().ToString();
            textBox2.Text = pentominos.Where(p => p.Type == Types.I).Count().ToString();
            textBox3.Text = pentominos.Where(p => p.Type == Types.L).Count().ToString();
            textBox4.Text = pentominos.Where(p => p.Type == Types.N).Count().ToString();
            textBox5.Text = pentominos.Where(p => p.Type == Types.P).Count().ToString();
            textBox6.Text = pentominos.Where(p => p.Type == Types.T).Count().ToString();
            textBox7.Text = pentominos.Where(p => p.Type == Types.U).Count().ToString();
            textBox8.Text = pentominos.Where(p => p.Type == Types.V).Count().ToString();
            textBox9.Text = pentominos.Where(p => p.Type == Types.W).Count().ToString();
            textBox10.Text = pentominos.Where(p => p.Type == Types.X).Count().ToString();
            textBox11.Text = pentominos.Where(p => p.Type == Types.Y).Count().ToString();
            textBox12.Text = pentominos.Where(p => p.Type == Types.Z).Count().ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
