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
        public Pentomino()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.loadFromFileRadio.Checked)
                pieceCounter.Enabled = false;
            else
                pieceCounter.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loadFromFileRadio.Checked)
            {
                var reader = new StreamReader("pieces.txt");
                string line = reader.ReadLine();
                var counts = line.Split(' ');

            }
            else
            {
                var random = new Random();
                for (int i = 0; i < pieceCounter.Value; i++)
                {
                    var count = random.Next(0, 11);

                }
            }
        }
    }
}
