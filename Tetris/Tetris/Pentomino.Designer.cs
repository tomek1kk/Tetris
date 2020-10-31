namespace Tetris
{
    partial class Pentomino
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
            this.piecesSourcePanel = new System.Windows.Forms.Panel();
            this.piecesSourceLabel = new System.Windows.Forms.Label();
            this.pieceCounter = new System.Windows.Forms.NumericUpDown();
            this.pieceCountLabel = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.piecesSourcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceCounter)).BeginInit();
            this.problemTypePanel.SuspendLayout();
            this.algorithmTypePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // piecesSourcePanel
            // 
            this.piecesSourcePanel.Controls.Add(this.piecesSourceLabel);
            this.piecesSourcePanel.Controls.Add(this.pieceCounter);
            this.piecesSourcePanel.Controls.Add(this.pieceCountLabel);
            this.piecesSourcePanel.Controls.Add(this.randomRadio);
            this.piecesSourcePanel.Controls.Add(this.loadFromFileRadio);
            this.piecesSourcePanel.Location = new System.Drawing.Point(29, 363);
            this.piecesSourcePanel.Name = "piecesSourcePanel";
            this.piecesSourcePanel.Size = new System.Drawing.Size(200, 146);
            this.piecesSourcePanel.TabIndex = 1;
            // 
            // piecesSourceLabel
            // 
            this.piecesSourceLabel.AutoSize = true;
            this.piecesSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.piecesSourceLabel.Location = new System.Drawing.Point(15, 12);
            this.piecesSourceLabel.Name = "piecesSourceLabel";
            this.piecesSourceLabel.Size = new System.Drawing.Size(173, 29);
            this.piecesSourceLabel.TabIndex = 7;
            this.piecesSourceLabel.Text = "Pieces source";
            // 
            // pieceCounter
            // 
            this.pieceCounter.Enabled = false;
            this.pieceCounter.Location = new System.Drawing.Point(98, 103);
            this.pieceCounter.Name = "pieceCounter";
            this.pieceCounter.Size = new System.Drawing.Size(60, 22);
            this.pieceCounter.TabIndex = 6;
            // 
            // pieceCountLabel
            // 
            this.pieceCountLabel.AutoSize = true;
            this.pieceCountLabel.Location = new System.Drawing.Point(3, 105);
            this.pieceCountLabel.Name = "pieceCountLabel";
            this.pieceCountLabel.Size = new System.Drawing.Size(89, 17);
            this.pieceCountLabel.TabIndex = 5;
            this.pieceCountLabel.Text = "Pieces count";
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(3, 81);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(82, 21);
            this.randomRadio.TabIndex = 3;
            this.randomRadio.Text = "Random";
            this.randomRadio.UseVisualStyleBackColor = true;
            this.randomRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // loadFromFileRadio
            // 
            this.loadFromFileRadio.AutoSize = true;
            this.loadFromFileRadio.Checked = true;
            this.loadFromFileRadio.Location = new System.Drawing.Point(3, 54);
            this.loadFromFileRadio.Name = "loadFromFileRadio";
            this.loadFromFileRadio.Size = new System.Drawing.Size(115, 21);
            this.loadFromFileRadio.TabIndex = 2;
            this.loadFromFileRadio.TabStop = true;
            this.loadFromFileRadio.Text = "Load from file";
            this.loadFromFileRadio.UseVisualStyleBackColor = true;
            this.loadFromFileRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.mainTitleLabel.Location = new System.Drawing.Point(237, 9);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(543, 58);
            this.mainTitleLabel.TabIndex = 7;
            this.mainTitleLabel.Text = "PENTOMINO SOLVER";
            // 
            // problemTypePanel
            // 
            this.problemTypePanel.Controls.Add(this.rectangleRadio);
            this.problemTypePanel.Controls.Add(this.squareRadio);
            this.problemTypePanel.Controls.Add(this.problemTypeLabel);
            this.problemTypePanel.Location = new System.Drawing.Point(29, 72);
            this.problemTypePanel.Name = "problemTypePanel";
            this.problemTypePanel.Size = new System.Drawing.Size(200, 114);
            this.problemTypePanel.TabIndex = 8;
            // 
            // rectangleRadio
            // 
            this.rectangleRadio.AutoSize = true;
            this.rectangleRadio.Location = new System.Drawing.Point(3, 81);
            this.rectangleRadio.Name = "rectangleRadio";
            this.rectangleRadio.Size = new System.Drawing.Size(93, 21);
            this.rectangleRadio.TabIndex = 2;
            this.rectangleRadio.Text = "Rectangle";
            this.rectangleRadio.UseVisualStyleBackColor = true;
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Checked = true;
            this.squareRadio.Location = new System.Drawing.Point(3, 54);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(75, 21);
            this.squareRadio.TabIndex = 1;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            // 
            // problemTypeLabel
            // 
            this.problemTypeLabel.AutoSize = true;
            this.problemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.problemTypeLabel.Location = new System.Drawing.Point(15, 13);
            this.problemTypeLabel.Name = "problemTypeLabel";
            this.problemTypeLabel.Size = new System.Drawing.Size(163, 29);
            this.problemTypeLabel.TabIndex = 0;
            this.problemTypeLabel.Text = "Problem type";
            // 
            // algorithmTypePanel
            // 
            this.algorithmTypePanel.Controls.Add(this.heuristicRadio);
            this.algorithmTypePanel.Controls.Add(this.accurateRadio);
            this.algorithmTypePanel.Controls.Add(this.algorithmTypeLabel);
            this.algorithmTypePanel.Location = new System.Drawing.Point(29, 218);
            this.algorithmTypePanel.Name = "algorithmTypePanel";
            this.algorithmTypePanel.Size = new System.Drawing.Size(200, 114);
            this.algorithmTypePanel.TabIndex = 9;
            // 
            // heuristicRadio
            // 
            this.heuristicRadio.AutoSize = true;
            this.heuristicRadio.Location = new System.Drawing.Point(3, 81);
            this.heuristicRadio.Name = "heuristicRadio";
            this.heuristicRadio.Size = new System.Drawing.Size(84, 21);
            this.heuristicRadio.TabIndex = 2;
            this.heuristicRadio.Text = "Heuristic";
            this.heuristicRadio.UseVisualStyleBackColor = true;
            // 
            // accurateRadio
            // 
            this.accurateRadio.AutoSize = true;
            this.accurateRadio.Checked = true;
            this.accurateRadio.Location = new System.Drawing.Point(3, 54);
            this.accurateRadio.Name = "accurateRadio";
            this.accurateRadio.Size = new System.Drawing.Size(85, 21);
            this.accurateRadio.TabIndex = 1;
            this.accurateRadio.TabStop = true;
            this.accurateRadio.Text = "Accurate";
            this.accurateRadio.UseVisualStyleBackColor = true;
            // 
            // algorithmTypeLabel
            // 
            this.algorithmTypeLabel.AutoSize = true;
            this.algorithmTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.algorithmTypeLabel.Location = new System.Drawing.Point(15, 15);
            this.algorithmTypeLabel.Name = "algorithmTypeLabel";
            this.algorithmTypeLabel.Size = new System.Drawing.Size(176, 29);
            this.algorithmTypeLabel.TabIndex = 0;
            this.algorithmTypeLabel.Text = "Algorithm type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(29, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(271, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 490);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(266, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pieces list";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 332);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Pentomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.algorithmTypePanel);
            this.Controls.Add(this.problemTypePanel);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.piecesSourcePanel);
            this.Name = "Pentomino";
            this.Text = "Pentomino";
            this.piecesSourcePanel.ResumeLayout(false);
            this.piecesSourcePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceCounter)).EndInit();
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
        private System.Windows.Forms.Panel piecesSourcePanel;
        private System.Windows.Forms.RadioButton loadFromFileRadio;
        private System.Windows.Forms.RadioButton randomRadio;
        private System.Windows.Forms.NumericUpDown pieceCounter;
        private System.Windows.Forms.Label pieceCountLabel;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Label piecesSourceLabel;
        private System.Windows.Forms.Panel problemTypePanel;
        private System.Windows.Forms.RadioButton rectangleRadio;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.Label problemTypeLabel;
        private System.Windows.Forms.Panel algorithmTypePanel;
        private System.Windows.Forms.RadioButton heuristicRadio;
        private System.Windows.Forms.RadioButton accurateRadio;
        private System.Windows.Forms.Label algorithmTypeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

