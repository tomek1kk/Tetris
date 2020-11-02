namespace Tetris
{
    partial class Tetris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.PentominosSourcePanel = new System.Windows.Forms.Panel();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.PentominosSourceLabel = new System.Windows.Forms.Label();
            this.pentominoCounter = new System.Windows.Forms.NumericUpDown();
            this.pentominoCountLabel = new System.Windows.Forms.Label();
            this.randomRadio = new System.Windows.Forms.RadioButton();
            this.loadFromFileRadio = new System.Windows.Forms.RadioButton();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.problemTypePanel = new System.Windows.Forms.Panel();
            this.rectangleRadio = new System.Windows.Forms.RadioButton();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.problemTypeLabel = new System.Windows.Forms.Label();
            this.algorithmTypePanel = new System.Windows.Forms.Panel();
            this.heuristicRadio = new System.Windows.Forms.RadioButton();
            this.accurateRadio = new System.Windows.Forms.RadioButton();
            this.algorithmTypeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelLL = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.solveButton = new System.Windows.Forms.Button();
            this.PentominosSourcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pentominoCounter)).BeginInit();
            this.problemTypePanel.SuspendLayout();
            this.algorithmTypePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PentominosSourcePanel
            // 
            this.PentominosSourcePanel.Controls.Add(this.filePathTextBox);
            this.PentominosSourcePanel.Controls.Add(this.browseButton);
            this.PentominosSourcePanel.Controls.Add(this.PentominosSourceLabel);
            this.PentominosSourcePanel.Controls.Add(this.pentominoCounter);
            this.PentominosSourcePanel.Controls.Add(this.pentominoCountLabel);
            this.PentominosSourcePanel.Controls.Add(this.randomRadio);
            this.PentominosSourcePanel.Controls.Add(this.loadFromFileRadio);
            this.PentominosSourcePanel.Location = new System.Drawing.Point(11, 291);
            this.PentominosSourcePanel.Margin = new System.Windows.Forms.Padding(2);
            this.PentominosSourcePanel.Name = "PentominosSourcePanel";
            this.PentominosSourcePanel.Size = new System.Drawing.Size(178, 138);
            this.PentominosSourcePanel.TabIndex = 1;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(4, 66);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(170, 20);
            this.filePathTextBox.TabIndex = 13;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(104, 42);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(56, 19);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // PentominosSourceLabel
            // 
            this.PentominosSourceLabel.AutoSize = true;
            this.PentominosSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PentominosSourceLabel.Location = new System.Drawing.Point(1, 8);
            this.PentominosSourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PentominosSourceLabel.Name = "PentominosSourceLabel";
            this.PentominosSourceLabel.Size = new System.Drawing.Size(179, 25);
            this.PentominosSourceLabel.TabIndex = 7;
            this.PentominosSourceLabel.Text = "Pentominos source";
            // 
            // pentominoCounter
            // 
            this.pentominoCounter.Enabled = false;
            this.pentominoCounter.Location = new System.Drawing.Point(111, 113);
            this.pentominoCounter.Margin = new System.Windows.Forms.Padding(2);
            this.pentominoCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pentominoCounter.Name = "pentominoCounter";
            this.pentominoCounter.Size = new System.Drawing.Size(45, 20);
            this.pentominoCounter.TabIndex = 6;
            this.pentominoCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pentominoCountLabel
            // 
            this.pentominoCountLabel.AutoSize = true;
            this.pentominoCountLabel.Location = new System.Drawing.Point(15, 115);
            this.pentominoCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pentominoCountLabel.Name = "pentominoCountLabel";
            this.pentominoCountLabel.Size = new System.Drawing.Size(92, 13);
            this.pentominoCountLabel.TabIndex = 5;
            this.pentominoCountLabel.Text = "Pentominos count";
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(15, 95);
            this.randomRadio.Margin = new System.Windows.Forms.Padding(2);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(65, 17);
            this.randomRadio.TabIndex = 3;
            this.randomRadio.Text = "Random";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // loadFromFileRadio
            // 
            this.loadFromFileRadio.AutoSize = true;
            this.loadFromFileRadio.Checked = true;
            this.loadFromFileRadio.Location = new System.Drawing.Point(15, 44);
            this.loadFromFileRadio.Margin = new System.Windows.Forms.Padding(2);
            this.loadFromFileRadio.Name = "loadFromFileRadio";
            this.loadFromFileRadio.Size = new System.Drawing.Size(88, 17);
            this.loadFromFileRadio.TabIndex = 2;
            this.loadFromFileRadio.TabStop = true;
            this.loadFromFileRadio.Text = "Load from file";
            this.loadFromFileRadio.UseVisualStyleBackColor = true;
            this.loadFromFileRadio.CheckedChanged += new System.EventHandler(this.loadFromFileRadio_CheckedChanged);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mainTitleLabel.Location = new System.Drawing.Point(208, -1);
            this.mainTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(435, 46);
            this.mainTitleLabel.TabIndex = 7;
            this.mainTitleLabel.Text = "PENTOMINO SOLVER";
            // 
            // problemTypePanel
            // 
            this.problemTypePanel.Controls.Add(this.rectangleRadio);
            this.problemTypePanel.Controls.Add(this.squareRadio);
            this.problemTypePanel.Controls.Add(this.problemTypeLabel);
            this.problemTypePanel.Location = new System.Drawing.Point(22, 58);
            this.problemTypePanel.Margin = new System.Windows.Forms.Padding(2);
            this.problemTypePanel.Name = "problemTypePanel";
            this.problemTypePanel.Size = new System.Drawing.Size(150, 93);
            this.problemTypePanel.TabIndex = 8;
            // 
            // rectangleRadio
            // 
            this.rectangleRadio.AutoSize = true;
            this.rectangleRadio.Location = new System.Drawing.Point(2, 66);
            this.rectangleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleRadio.Name = "rectangleRadio";
            this.rectangleRadio.Size = new System.Drawing.Size(74, 17);
            this.rectangleRadio.TabIndex = 2;
            this.rectangleRadio.Text = "Rectangle";
            this.rectangleRadio.UseVisualStyleBackColor = true;
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Checked = true;
            this.squareRadio.Location = new System.Drawing.Point(2, 44);
            this.squareRadio.Margin = new System.Windows.Forms.Padding(2);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(59, 17);
            this.squareRadio.TabIndex = 1;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            // 
            // problemTypeLabel
            // 
            this.problemTypeLabel.AutoSize = true;
            this.problemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.problemTypeLabel.Location = new System.Drawing.Point(11, 11);
            this.problemTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.problemTypeLabel.Name = "problemTypeLabel";
            this.problemTypeLabel.Size = new System.Drawing.Size(126, 25);
            this.problemTypeLabel.TabIndex = 0;
            this.problemTypeLabel.Text = "Problem type";
            // 
            // algorithmTypePanel
            // 
            this.algorithmTypePanel.Controls.Add(this.heuristicRadio);
            this.algorithmTypePanel.Controls.Add(this.accurateRadio);
            this.algorithmTypePanel.Controls.Add(this.algorithmTypeLabel);
            this.algorithmTypePanel.Location = new System.Drawing.Point(22, 177);
            this.algorithmTypePanel.Margin = new System.Windows.Forms.Padding(2);
            this.algorithmTypePanel.Name = "algorithmTypePanel";
            this.algorithmTypePanel.Size = new System.Drawing.Size(150, 93);
            this.algorithmTypePanel.TabIndex = 9;
            // 
            // heuristicRadio
            // 
            this.heuristicRadio.AutoSize = true;
            this.heuristicRadio.Location = new System.Drawing.Point(2, 66);
            this.heuristicRadio.Margin = new System.Windows.Forms.Padding(2);
            this.heuristicRadio.Name = "heuristicRadio";
            this.heuristicRadio.Size = new System.Drawing.Size(66, 17);
            this.heuristicRadio.TabIndex = 2;
            this.heuristicRadio.Text = "Heuristic";
            this.heuristicRadio.UseVisualStyleBackColor = true;
            // 
            // accurateRadio
            // 
            this.accurateRadio.AutoSize = true;
            this.accurateRadio.Checked = true;
            this.accurateRadio.Location = new System.Drawing.Point(2, 44);
            this.accurateRadio.Margin = new System.Windows.Forms.Padding(2);
            this.accurateRadio.Name = "accurateRadio";
            this.accurateRadio.Size = new System.Drawing.Size(68, 17);
            this.accurateRadio.TabIndex = 1;
            this.accurateRadio.TabStop = true;
            this.accurateRadio.Text = "Accurate";
            this.accurateRadio.UseVisualStyleBackColor = true;
            // 
            // algorithmTypeLabel
            // 
            this.algorithmTypeLabel.AutoSize = true;
            this.algorithmTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.algorithmTypeLabel.Location = new System.Drawing.Point(11, 12);
            this.algorithmTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algorithmTypeLabel.Name = "algorithmTypeLabel";
            this.algorithmTypeLabel.Size = new System.Drawing.Size(136, 25);
            this.algorithmTypeLabel.TabIndex = 0;
            this.algorithmTypeLabel.Text = "Algorithm type";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(26, 467);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 32);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelZ);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.labelW);
            this.panel1.Controls.Add(this.labelV);
            this.panel1.Controls.Add(this.labell);
            this.panel1.Controls.Add(this.labelU);
            this.panel1.Controls.Add(this.labelT);
            this.panel1.Controls.Add(this.labelP);
            this.panel1.Controls.Add(this.labelN);
            this.panel1.Controls.Add(this.labelLL);
            this.panel1.Controls.Add(this.labelI);
            this.panel1.Controls.Add(this.labelF);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(203, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 488);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(439, 455);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(13, 13);
            this.labelZ.TabIndex = 14;
            this.labelZ.Text = "0";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(324, 455);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(13, 13);
            this.labelY.TabIndex = 13;
            this.labelY.Text = "0";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(224, 455);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(13, 13);
            this.labelX.TabIndex = 12;
            this.labelX.Text = "0";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(120, 455);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(13, 13);
            this.labelW.TabIndex = 11;
            this.labelW.Text = "0";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(439, 298);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(13, 13);
            this.labelV.TabIndex = 10;
            this.labelV.Text = "0";
            // 
            // labell
            // 
            this.labell.Location = new System.Drawing.Point(0, 0);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(100, 23);
            this.labell.TabIndex = 15;
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(324, 298);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(13, 13);
            this.labelU.TabIndex = 8;
            this.labelU.Text = "0";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(224, 298);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(13, 13);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "0";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(120, 298);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(13, 13);
            this.labelP.TabIndex = 6;
            this.labelP.Text = "0";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(439, 164);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(13, 13);
            this.labelN.TabIndex = 5;
            this.labelN.Text = "0";
            // 
            // labelLL
            // 
            this.labelLL.AutoSize = true;
            this.labelLL.Location = new System.Drawing.Point(324, 164);
            this.labelLL.Name = "labelLL";
            this.labelLL.Size = new System.Drawing.Size(13, 13);
            this.labelLL.TabIndex = 4;
            this.labelLL.Text = "0";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(224, 164);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(13, 13);
            this.labelI.TabIndex = 3;
            this.labelI.Text = "0";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(120, 164);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(13, 13);
            this.labelF.TabIndex = 2;
            this.labelF.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 466);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(61, 504);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 12;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 558);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.algorithmTypePanel);
            this.Controls.Add(this.problemTypePanel);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.PentominosSourcePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tetris";
            this.Text = "Pentomino";
            this.PentominosSourcePanel.ResumeLayout(false);
            this.PentominosSourcePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pentominoCounter)).EndInit();
            this.problemTypePanel.ResumeLayout(false);
            this.problemTypePanel.PerformLayout();
            this.algorithmTypePanel.ResumeLayout(false);
            this.algorithmTypePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PentominosSourcePanel;
        private System.Windows.Forms.RadioButton loadFromFileRadio;
        private System.Windows.Forms.RadioButton randomRadio;
        private System.Windows.Forms.NumericUpDown pentominoCounter;
        private System.Windows.Forms.Label pentominoCountLabel;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Label PentominosSourceLabel;
        private System.Windows.Forms.Panel problemTypePanel;
        private System.Windows.Forms.RadioButton rectangleRadio;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.Label problemTypeLabel;
        private System.Windows.Forms.Panel algorithmTypePanel;
        private System.Windows.Forms.RadioButton heuristicRadio;
        private System.Windows.Forms.RadioButton accurateRadio;
        private System.Windows.Forms.Label algorithmTypeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelLL;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Button solveButton;
    }
}

