using System.Collections.Generic;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.PentominosSourcePanel = new System.Windows.Forms.Panel();
            this.tasksFromFileaLabel = new System.Windows.Forms.Label();
            this.keyboardRadio = new System.Windows.Forms.RadioButton();
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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.solveButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.SolutionView = new System.Windows.Forms.PictureBox();
            this.solutionCounter = new System.Windows.Forms.NumericUpDown();
            this.changeSolutionButton = new System.Windows.Forms.Button();
            this.solutionsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.cutsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.processingLabel = new System.Windows.Forms.Label();
            this.nextTaskButton = new System.Windows.Forms.Button();
            this.limitSolutionsCheckbox = new System.Windows.Forms.CheckBox();
            this.solutionsLimitCounter = new System.Windows.Forms.NumericUpDown();
            this.PentominosSourcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pentominoCounter)).BeginInit();
            this.problemTypePanel.SuspendLayout();
            this.algorithmTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionView)).BeginInit();
            this.SolutionView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionCounter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionsLimitCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // PentominosSourcePanel
            // 
            this.PentominosSourcePanel.Controls.Add(this.tasksFromFileaLabel);
            this.PentominosSourcePanel.Controls.Add(this.keyboardRadio);
            this.PentominosSourcePanel.Controls.Add(this.filePathTextBox);
            this.PentominosSourcePanel.Controls.Add(this.browseButton);
            this.PentominosSourcePanel.Controls.Add(this.PentominosSourceLabel);
            this.PentominosSourcePanel.Controls.Add(this.pentominoCounter);
            this.PentominosSourcePanel.Controls.Add(this.pentominoCountLabel);
            this.PentominosSourcePanel.Controls.Add(this.randomRadio);
            this.PentominosSourcePanel.Controls.Add(this.loadFromFileRadio);
            this.PentominosSourcePanel.Location = new System.Drawing.Point(37, 326);
            this.PentominosSourcePanel.Margin = new System.Windows.Forms.Padding(2);
            this.PentominosSourcePanel.Name = "PentominosSourcePanel";
            this.PentominosSourcePanel.Size = new System.Drawing.Size(188, 199);
            this.PentominosSourcePanel.TabIndex = 1;
            // 
            // tasksFromFileaLabel
            // 
            this.tasksFromFileaLabel.AutoSize = true;
            this.tasksFromFileaLabel.Location = new System.Drawing.Point(13, 89);
            this.tasksFromFileaLabel.Name = "tasksFromFileaLabel";
            this.tasksFromFileaLabel.Size = new System.Drawing.Size(72, 13);
            this.tasksFromFileaLabel.TabIndex = 15;
            this.tasksFromFileaLabel.Text = "No file loaded";
            // 
            // keyboardRadio
            // 
            this.keyboardRadio.AutoSize = true;
            this.keyboardRadio.Location = new System.Drawing.Point(15, 163);
            this.keyboardRadio.Margin = new System.Windows.Forms.Padding(2);
            this.keyboardRadio.Name = "keyboardRadio";
            this.keyboardRadio.Size = new System.Drawing.Size(119, 17);
            this.keyboardRadio.TabIndex = 14;
            this.keyboardRadio.TabStop = true;
            this.keyboardRadio.Text = "Load from keyboard";
            this.keyboardRadio.UseVisualStyleBackColor = true;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(2, 65);
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
            this.pentominoCounter.Location = new System.Drawing.Point(109, 132);
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
            this.pentominoCountLabel.Location = new System.Drawing.Point(13, 134);
            this.pentominoCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pentominoCountLabel.Name = "pentominoCountLabel";
            this.pentominoCountLabel.Size = new System.Drawing.Size(92, 13);
            this.pentominoCountLabel.TabIndex = 5;
            this.pentominoCountLabel.Text = "Pentominos count";
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(15, 115);
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
            this.mainTitleLabel.Location = new System.Drawing.Point(29, 22);
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
            this.problemTypePanel.Location = new System.Drawing.Point(37, 93);
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
            this.squareRadio.CheckedChanged += new System.EventHandler(this.squareRadio_CheckedChanged);
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
            this.algorithmTypePanel.Location = new System.Drawing.Point(37, 215);
            this.algorithmTypePanel.Margin = new System.Windows.Forms.Padding(2);
            this.algorithmTypePanel.Name = "algorithmTypePanel";
            this.algorithmTypePanel.Size = new System.Drawing.Size(150, 93);
            this.algorithmTypePanel.TabIndex = 9;
            // 
            // heuristicRadio
            // 
            this.heuristicRadio.AutoSize = true;
            this.heuristicRadio.Checked = true;
            this.heuristicRadio.Location = new System.Drawing.Point(2, 66);
            this.heuristicRadio.Margin = new System.Windows.Forms.Padding(2);
            this.heuristicRadio.Name = "heuristicRadio";
            this.heuristicRadio.Size = new System.Drawing.Size(66, 17);
            this.heuristicRadio.TabIndex = 2;
            this.heuristicRadio.TabStop = true;
            this.heuristicRadio.Text = "Heuristic";
            this.heuristicRadio.UseVisualStyleBackColor = true;
            // 
            // accurateRadio
            // 
            this.accurateRadio.AutoSize = true;
            this.accurateRadio.Location = new System.Drawing.Point(2, 44);
            this.accurateRadio.Margin = new System.Windows.Forms.Padding(2);
            this.accurateRadio.Name = "accurateRadio";
            this.accurateRadio.Size = new System.Drawing.Size(68, 17);
            this.accurateRadio.TabIndex = 1;
            this.accurateRadio.Text = "Accurate";
            this.accurateRadio.UseVisualStyleBackColor = true;
            this.accurateRadio.CheckedChanged += new System.EventHandler(this.accurateRadio_CheckedChanged);
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
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(37, 522);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 32);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Show pieces";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // solveButton
            // 
            this.solveButton.Enabled = false;
            this.solveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.solveButton.Location = new System.Drawing.Point(37, 593);
            this.solveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(150, 34);
            this.solveButton.TabIndex = 12;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 679);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 583);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(263, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(338, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(414, 160);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(481, 160);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(25, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(85, 342);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(25, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(177, 342);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(25, 20);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(242, 342);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(25, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(317, 342);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(25, 20);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(414, 342);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(25, 20);
            this.textBox11.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(481, 342);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(25, 20);
            this.textBox12.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(85, 516);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(25, 20);
            this.textBox13.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(177, 516);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(25, 20);
            this.textBox14.TabIndex = 15;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(242, 516);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(25, 20);
            this.textBox15.TabIndex = 16;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(338, 516);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(25, 20);
            this.textBox16.TabIndex = 17;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(414, 516);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(25, 20);
            this.textBox17.TabIndex = 18;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(481, 516);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(25, 20);
            this.textBox18.TabIndex = 19;
            // 
            // SolutionView
            // 
            this.SolutionView.Controls.Add(this.solutionCounter);
            this.SolutionView.Controls.Add(this.changeSolutionButton);
            this.SolutionView.Controls.Add(this.solutionsLabel);
            this.SolutionView.Controls.Add(this.tableLayoutPanel1);
            this.SolutionView.Controls.Add(this.elapsedTime);
            this.SolutionView.Controls.Add(this.cutsLabel);
            this.SolutionView.Location = new System.Drawing.Point(274, 70);
            this.SolutionView.Name = "SolutionView";
            this.SolutionView.Size = new System.Drawing.Size(561, 557);
            this.SolutionView.TabIndex = 18;
            this.SolutionView.TabStop = false;
            this.SolutionView.Visible = false;
            // 
            // solutionCounter
            // 
            this.solutionCounter.Location = new System.Drawing.Point(338, 525);
            this.solutionCounter.Margin = new System.Windows.Forms.Padding(2);
            this.solutionCounter.Name = "solutionCounter";
            this.solutionCounter.Size = new System.Drawing.Size(49, 20);
            this.solutionCounter.TabIndex = 16;
            // 
            // changeSolutionButton
            // 
            this.changeSolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.changeSolutionButton.Location = new System.Drawing.Point(472, 519);
            this.changeSolutionButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeSolutionButton.Name = "changeSolutionButton";
            this.changeSolutionButton.Size = new System.Drawing.Size(56, 26);
            this.changeSolutionButton.TabIndex = 23;
            this.changeSolutionButton.Text = "Go";
            this.changeSolutionButton.UseVisualStyleBackColor = true;
            this.changeSolutionButton.Click += new System.EventHandler(this.changeSolutionButton_Click);
            // 
            // solutionsLabel
            // 
            this.solutionsLabel.AutoSize = true;
            this.solutionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.solutionsLabel.Location = new System.Drawing.Point(251, 519);
            this.solutionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.solutionsLabel.Name = "solutionsLabel";
            this.solutionsLabel.Size = new System.Drawing.Size(84, 24);
            this.solutionsLabel.TabIndex = 22;
            this.solutionsLabel.Text = "solutions";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 467);
            this.tableLayoutPanel1.TabIndex = 21;
            this.tableLayoutPanel1.Visible = false;
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.elapsedTime.Location = new System.Drawing.Point(375, 0);
            this.elapsedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(97, 18);
            this.elapsedTime.TabIndex = 20;
            this.elapsedTime.Text = "Elapsed time:";
            // 
            // cutsLabel
            // 
            this.cutsLabel.AutoSize = true;
            this.cutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cutsLabel.Location = new System.Drawing.Point(262, 0);
            this.cutsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cutsLabel.Name = "cutsLabel";
            this.cutsLabel.Size = new System.Drawing.Size(43, 18);
            this.cutsLabel.TabIndex = 20;
            this.cutsLabel.Text = "Cuts:";
            this.cutsLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.processingLabel);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(274, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 598);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // processingLabel
            // 
            this.processingLabel.AutoSize = true;
            this.processingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.processingLabel.Location = new System.Drawing.Point(293, 561);
            this.processingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(99, 20);
            this.processingLabel.TabIndex = 20;
            this.processingLabel.Text = "Processing...";
            this.processingLabel.Visible = false;
            // 
            // nextTaskButton
            // 
            this.nextTaskButton.Enabled = false;
            this.nextTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextTaskButton.Location = new System.Drawing.Point(37, 559);
            this.nextTaskButton.Name = "nextTaskButton";
            this.nextTaskButton.Size = new System.Drawing.Size(150, 26);
            this.nextTaskButton.TabIndex = 19;
            this.nextTaskButton.Text = "Next task";
            this.nextTaskButton.UseVisualStyleBackColor = true;
            this.nextTaskButton.Click += new System.EventHandler(this.nextTaskButton_Click);
            // 
            // limitSolutionsCheckbox
            // 
            this.limitSolutionsCheckbox.AutoSize = true;
            this.limitSolutionsCheckbox.Location = new System.Drawing.Point(104, 637);
            this.limitSolutionsCheckbox.Name = "limitSolutionsCheckbox";
            this.limitSolutionsCheckbox.Size = new System.Drawing.Size(87, 17);
            this.limitSolutionsCheckbox.TabIndex = 20;
            this.limitSolutionsCheckbox.Text = "solutions limit";
            this.limitSolutionsCheckbox.UseVisualStyleBackColor = true;
            this.limitSolutionsCheckbox.CheckedChanged += new System.EventHandler(this.limitSolutionsCheckbox_CheckedChanged);
            // 
            // solutionsLimitCounter
            // 
            this.solutionsLimitCounter.Location = new System.Drawing.Point(39, 636);
            this.solutionsLimitCounter.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.solutionsLimitCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.solutionsLimitCounter.Name = "solutionsLimitCounter";
            this.solutionsLimitCounter.Size = new System.Drawing.Size(59, 20);
            this.solutionsLimitCounter.TabIndex = 21;
            this.solutionsLimitCounter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.solutionsLimitCounter.ValueChanged += new System.EventHandler(this.solutionsLimitCounter_ValueChanged);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 679);
            this.Controls.Add(this.solutionsLimitCounter);
            this.Controls.Add(this.limitSolutionsCheckbox);
            this.Controls.Add(this.nextTaskButton);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SolutionView);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionView)).EndInit();
            this.SolutionView.ResumeLayout(false);
            this.SolutionView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionCounter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionsLimitCounter)).EndInit();
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
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RadioButton keyboardRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.PictureBox SolutionView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label solutionsLabel;
        private System.Windows.Forms.Button changeSolutionButton;
        private System.Windows.Forms.NumericUpDown solutionCounter;
        private System.Windows.Forms.Panel panel1;
        private Label elapsedTime;
        private Label cutsLabel;
        private Label processingLabel;
        private Button nextTaskButton;
        private Label tasksFromFileaLabel;
        private CheckBox limitSolutionsCheckbox;
        private NumericUpDown solutionsLimitCounter;
    }
}

