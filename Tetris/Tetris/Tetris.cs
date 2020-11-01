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
        List<Pentomino> pentominos;
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
            pentominos = new List<Pentomino>();
            if (loadFromFileRadio.Checked)
                LoadPentominosFromFile();
            else
                GenerateRandomPentominos();
            // TODO: wyswietlic liste w GUI i zrobic cos z Pentominos
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
                    pentominos.Add(new Pentomino((Types)i));
            }
        }

        private void GenerateRandomPentominos()
        {
            var random = new Random();
            for (int i = 0; i < pentominoCounter.Value; i++)
            {
                var pentomino = random.Next(0, 11);
                pentominos.Add(new Pentomino((Types)pentomino));
            }
        }

    }
}
