using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris : Form
    {
        private string filePath;
        List<Polymino> pentominos;
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
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Generowanie klockow
            pentominos = new List<Polymino>();
            if (loadFromFileRadio.Checked)
                LoadPentominosFromFile();
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

        private void LoadPentominosFromFile()
        {
            // TODO: przydało by się jakieś sprawdzenie, czy wnętrze pliku jest w odpowiedniej formie
            var reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            var counts = line.Split(' ');
            for (int i = 0; i < counts.Length; i++)
            {
                var count = Int32.Parse(counts[i]);
                for (int j = 0; j < count; j++)
                    pentominos.Add(new Polymino((Types)i));
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

        private void solveButton_Click(object sender, EventArgs e)
        {
            //pentominos = new List<Polymino> { new Polymino(Types.I), new Polymino(Types.L) };
            pentominos = new List<Polymino> { new Polymino(Types.L) };
            var solution = Solver.Solve(squareRadio.Checked ? ProblemType.Square : ProblemType.Rectangle, accurateRadio.Checked ? AlgorithmType.Precise : AlgorithmType.Heuristic, pentominos);
        }
    }
}
