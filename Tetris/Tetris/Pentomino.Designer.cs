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
            this.loadFromFileRadio = new System.Windows.Forms.RadioButton();
            this.randomRadio = new System.Windows.Forms.RadioButton();
            this.pieceCountLabel = new System.Windows.Forms.Label();
            this.pieceCounter = new System.Windows.Forms.NumericUpDown();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.piecesSourceLabel = new System.Windows.Forms.Label();
            this.problemTypePanel = new System.Windows.Forms.Panel();
            this.problemTypeLabel = new System.Windows.Forms.Label();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.rectangleRadio = new System.Windows.Forms.RadioButton();
            this.algorithmTypePanel = new System.Windows.Forms.Panel();
            this.heuristicRadio = new System.Windows.Forms.RadioButton();
            this.accurateRadio = new System.Windows.Forms.RadioButton();
            this.algorithmTypeLabel = new System.Windows.Forms.Label();
            this.piecesSourcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceCounter)).BeginInit();
            this.problemTypePanel.SuspendLayout();
            this.algorithmTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // piecesSourcePanel
            // 
            this.piecesSourcePanel.Controls.Add(this.piecesSourceLabel);
            this.piecesSourcePanel.Controls.Add(this.pieceCounter);
            this.piecesSourcePanel.Controls.Add(this.pieceCountLabel);
            this.piecesSourcePanel.Controls.Add(this.randomRadio);
            this.piecesSourcePanel.Controls.Add(this.loadFromFileRadio);
            this.piecesSourcePanel.Location = new System.Drawing.Point(29, 397);
            this.piecesSourcePanel.Name = "piecesSourcePanel";
            this.piecesSourcePanel.Size = new System.Drawing.Size(200, 146);
            this.piecesSourcePanel.TabIndex = 1;
            // 
            // loadFromFileRadio
            // 
            this.loadFromFileRadio.AutoSize = true;
            this.loadFromFileRadio.Location = new System.Drawing.Point(3, 54);
            this.loadFromFileRadio.Name = "loadFromFileRadio";
            this.loadFromFileRadio.Size = new System.Drawing.Size(115, 21);
            this.loadFromFileRadio.TabIndex = 2;
            this.loadFromFileRadio.TabStop = true;
            this.loadFromFileRadio.Text = "Load from file";
            this.loadFromFileRadio.UseVisualStyleBackColor = true;
            this.loadFromFileRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(3, 81);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(82, 21);
            this.randomRadio.TabIndex = 3;
            this.randomRadio.TabStop = true;
            this.randomRadio.Text = "Random";
            this.randomRadio.UseVisualStyleBackColor = true;
            this.randomRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // pieceCounter
            // 
            this.pieceCounter.Enabled = false;
            this.pieceCounter.Location = new System.Drawing.Point(98, 103);
            this.pieceCounter.Name = "pieceCounter";
            this.pieceCounter.Size = new System.Drawing.Size(60, 22);
            this.pieceCounter.TabIndex = 6;
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
            // problemTypePanel
            // 
            this.problemTypePanel.Controls.Add(this.rectangleRadio);
            this.problemTypePanel.Controls.Add(this.squareRadio);
            this.problemTypePanel.Controls.Add(this.problemTypeLabel);
            this.problemTypePanel.Location = new System.Drawing.Point(29, 106);
            this.problemTypePanel.Name = "problemTypePanel";
            this.problemTypePanel.Size = new System.Drawing.Size(200, 114);
            this.problemTypePanel.TabIndex = 8;
            // 
            // problemTypeLabel
            // 
            this.problemTypeLabel.AutoSize = true;
            this.problemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.problemTypeLabel.Location = new System.Drawing.Point(15, 15);
            this.problemTypeLabel.Name = "problemTypeLabel";
            this.problemTypeLabel.Size = new System.Drawing.Size(163, 29);
            this.problemTypeLabel.TabIndex = 0;
            this.problemTypeLabel.Text = "Problem type";
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Location = new System.Drawing.Point(3, 54);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(75, 21);
            this.squareRadio.TabIndex = 1;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            // 
            // rectangleRadio
            // 
            this.rectangleRadio.AutoSize = true;
            this.rectangleRadio.Location = new System.Drawing.Point(3, 81);
            this.rectangleRadio.Name = "rectangleRadio";
            this.rectangleRadio.Size = new System.Drawing.Size(93, 21);
            this.rectangleRadio.TabIndex = 2;
            this.rectangleRadio.TabStop = true;
            this.rectangleRadio.Text = "Rectangle";
            this.rectangleRadio.UseVisualStyleBackColor = true;
            // 
            // algorithmTypePanel
            // 
            this.algorithmTypePanel.Controls.Add(this.heuristicRadio);
            this.algorithmTypePanel.Controls.Add(this.accurateRadio);
            this.algorithmTypePanel.Controls.Add(this.algorithmTypeLabel);
            this.algorithmTypePanel.Location = new System.Drawing.Point(29, 252);
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
            this.heuristicRadio.TabStop = true;
            this.heuristicRadio.Text = "Heuristic";
            this.heuristicRadio.UseVisualStyleBackColor = true;
            // 
            // accurateRadio
            // 
            this.accurateRadio.AutoSize = true;
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
            // Pentomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 600);
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
    }
}

