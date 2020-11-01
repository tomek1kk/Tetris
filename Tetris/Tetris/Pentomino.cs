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
    public partial class Pentomino : Form
    {
        private string filePath;
        List<Piece> pieces;
        public Pentomino()
        {
            InitializeComponent();
        }

        private void loadFromFileRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (loadFromFileRadio.Checked)
            {
                pieceCounter.Enabled = false;
                if (filePath != null && filePath.Length > 0)
                    startButton.Enabled = true;
                else
                    startButton.Enabled = false;
            }
            else
            {
                pieceCounter.Enabled = true;
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Generowanie klockow
            pieces = new List<Piece>();
            if (loadFromFileRadio.Checked)
                LoadPiecesFromFile();
            else
                GenerateRandomPieces();
            // TODO: wyswietlic liste w GUI i zrobic cos z pieces
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

        private void LoadPiecesFromFile()
        {
            // TODO: przydało by się jakieś sprawdzenie, czy wnętrze pliku jest w odpowiedniej formie
            var reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            var counts = line.Split(' ');
            for (int i = 0; i < counts.Length; i++)
            {
                var count = Int32.Parse(counts[i]);
                for (int j = 0; j < count; j++)
                    pieces.Add(new Piece((Types)i));
            }
        }

        private void GenerateRandomPieces()
        {
            var random = new Random();
            for (int i = 0; i < pieceCounter.Value; i++)
            {
                var piece = random.Next(0, 11);
                pieces.Add(new Piece((Types)piece));
            }
        }

    }
}
