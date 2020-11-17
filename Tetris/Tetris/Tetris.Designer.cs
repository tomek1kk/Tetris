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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SolutionView = new System.Windows.Forms.PictureBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.solveButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.solutionsLabel = new System.Windows.Forms.Label();
            this.changeSolutionButton = new System.Windows.Forms.Button();
            this.solutionCounter = new System.Windows.Forms.NumericUpDown();
            this.PentominosSourcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pentominoCounter)).BeginInit();
            this.problemTypePanel.SuspendLayout();
            this.algorithmTypePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // PentominosSourcePanel
            // 
            this.PentominosSourcePanel.Controls.Add(this.keyboardRadio);
            this.PentominosSourcePanel.Controls.Add(this.filePathTextBox);
            this.PentominosSourcePanel.Controls.Add(this.browseButton);
            this.PentominosSourcePanel.Controls.Add(this.PentominosSourceLabel);
            this.PentominosSourcePanel.Controls.Add(this.pentominoCounter);
            this.PentominosSourcePanel.Controls.Add(this.pentominoCountLabel);
            this.PentominosSourcePanel.Controls.Add(this.randomRadio);
            this.PentominosSourcePanel.Controls.Add(this.loadFromFileRadio);
            this.PentominosSourcePanel.Location = new System.Drawing.Point(49, 401);
            this.PentominosSourcePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PentominosSourcePanel.Name = "PentominosSourcePanel";
            this.PentominosSourcePanel.Size = new System.Drawing.Size(251, 220);
            this.PentominosSourcePanel.TabIndex = 1;
            // 
            // keyboardRadio
            // 
            this.keyboardRadio.AutoSize = true;
            this.keyboardRadio.Location = new System.Drawing.Point(20, 180);
            this.keyboardRadio.Name = "keyboardRadio";
            this.keyboardRadio.Size = new System.Drawing.Size(156, 21);
            this.keyboardRadio.TabIndex = 14;
            this.keyboardRadio.TabStop = true;
            this.keyboardRadio.Text = "Load from keyboard";
            this.keyboardRadio.UseVisualStyleBackColor = true;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(5, 81);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(225, 22);
            this.filePathTextBox.TabIndex = 13;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(139, 52);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // PentominosSourceLabel
            // 
            this.PentominosSourceLabel.AutoSize = true;
            this.PentominosSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PentominosSourceLabel.Location = new System.Drawing.Point(1, 10);
            this.PentominosSourceLabel.Name = "PentominosSourceLabel";
            this.PentominosSourceLabel.Size = new System.Drawing.Size(231, 29);
            this.PentominosSourceLabel.TabIndex = 7;
            this.PentominosSourceLabel.Text = "Pentominos source";
            // 
            // pentominoCounter
            // 
            this.pentominoCounter.Enabled = false;
            this.pentominoCounter.Location = new System.Drawing.Point(148, 139);
            this.pentominoCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pentominoCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pentominoCounter.Name = "pentominoCounter";
            this.pentominoCounter.Size = new System.Drawing.Size(60, 22);
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
            this.pentominoCountLabel.Location = new System.Drawing.Point(20, 142);
            this.pentominoCountLabel.Name = "pentominoCountLabel";
            this.pentominoCountLabel.Size = new System.Drawing.Size(121, 17);
            this.pentominoCountLabel.TabIndex = 5;
            this.pentominoCountLabel.Text = "Pentominos count";
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(20, 117);
            this.randomRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(82, 21);
            this.randomRadio.TabIndex = 3;
            this.randomRadio.Text = "Random";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // loadFromFileRadio
            // 
            this.loadFromFileRadio.AutoSize = true;
            this.loadFromFileRadio.Checked = true;
            this.loadFromFileRadio.Location = new System.Drawing.Point(20, 54);
            this.loadFromFileRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadFromFileRadio.Name = "loadFromFileRadio";
            this.loadFromFileRadio.Size = new System.Drawing.Size(115, 21);
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
            this.mainTitleLabel.Location = new System.Drawing.Point(39, 27);
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
            this.problemTypePanel.Location = new System.Drawing.Point(49, 114);
            this.problemTypePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemTypePanel.Name = "problemTypePanel";
            this.problemTypePanel.Size = new System.Drawing.Size(200, 114);
            this.problemTypePanel.TabIndex = 8;
            // 
            // rectangleRadio
            // 
            this.rectangleRadio.AutoSize = true;
            this.rectangleRadio.Location = new System.Drawing.Point(3, 81);
            this.rectangleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.squareRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(75, 21);
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
            this.problemTypeLabel.Location = new System.Drawing.Point(15, 14);
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
            this.algorithmTypePanel.Location = new System.Drawing.Point(49, 265);
            this.algorithmTypePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmTypePanel.Name = "algorithmTypePanel";
            this.algorithmTypePanel.Size = new System.Drawing.Size(200, 114);
            this.algorithmTypePanel.TabIndex = 9;
            // 
            // heuristicRadio
            // 
            this.heuristicRadio.AutoSize = true;
            this.heuristicRadio.Location = new System.Drawing.Point(3, 81);
            this.heuristicRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.accurateRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accurateRadio.Name = "accurateRadio";
            this.accurateRadio.Size = new System.Drawing.Size(85, 21);
            this.accurateRadio.TabIndex = 1;
            this.accurateRadio.TabStop = true;
            this.accurateRadio.Text = "Accurate";
            this.accurateRadio.UseVisualStyleBackColor = true;
            this.accurateRadio.CheckedChanged += new System.EventHandler(this.accurateRadio_CheckedChanged);
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
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(49, 625);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 39);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.solutionCounter);
            this.panel1.Controls.Add(this.changeSolutionButton);
            this.panel1.Controls.Add(this.solutionsLabel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.SolutionView);
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
            this.panel1.Location = new System.Drawing.Point(365, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 736);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 575);
            this.tableLayoutPanel1.TabIndex = 21;
            this.tableLayoutPanel1.Visible = false;
            // 
            // SolutionView
            // 
            this.SolutionView.Location = new System.Drawing.Point(73, 11);
            this.SolutionView.Margin = new System.Windows.Forms.Padding(4);
            this.SolutionView.Name = "SolutionView";
            this.SolutionView.Size = new System.Drawing.Size(748, 686);
            this.SolutionView.TabIndex = 20;
            this.SolutionView.TabStop = false;
            this.SolutionView.Visible = false;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(641, 635);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(32, 22);
            this.textBox18.TabIndex = 19;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(552, 635);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(32, 22);
            this.textBox17.TabIndex = 18;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(451, 635);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(32, 22);
            this.textBox16.TabIndex = 17;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(323, 635);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(32, 22);
            this.textBox15.TabIndex = 16;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(236, 635);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(32, 22);
            this.textBox14.TabIndex = 15;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(113, 635);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(32, 22);
            this.textBox13.TabIndex = 14;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(641, 421);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(32, 22);
            this.textBox12.TabIndex = 13;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(552, 421);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(32, 22);
            this.textBox11.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(423, 421);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(32, 22);
            this.textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(323, 421);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(32, 22);
            this.textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(236, 421);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(32, 22);
            this.textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(113, 421);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 22);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(641, 197);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(552, 197);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(451, 197);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 197);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 197);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 197);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 22);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 718);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(49, 692);
            this.solveButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(100, 28);
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
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 836);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // solutionsLabel
            // 
            this.solutionsLabel.AutoSize = true;
            this.solutionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.solutionsLabel.Location = new System.Drawing.Point(335, 639);
            this.solutionsLabel.Name = "solutionsLabel";
            this.solutionsLabel.Size = new System.Drawing.Size(109, 29);
            this.solutionsLabel.TabIndex = 22;
            this.solutionsLabel.Text = "solutions";
            // 
            // changeSolutionButton
            // 
            this.changeSolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.changeSolutionButton.Location = new System.Drawing.Point(598, 639);
            this.changeSolutionButton.Name = "changeSolutionButton";
            this.changeSolutionButton.Size = new System.Drawing.Size(75, 32);
            this.changeSolutionButton.TabIndex = 23;
            this.changeSolutionButton.Text = "Go";
            this.changeSolutionButton.UseVisualStyleBackColor = true;
            // 
            // solutionCounter
            // 
            this.solutionCounter.Location = new System.Drawing.Point(450, 646);
            this.solutionCounter.Name = "solutionCounter";
            this.solutionCounter.Size = new System.Drawing.Size(65, 22);
            this.solutionCounter.TabIndex = 16;
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 836);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.algorithmTypePanel);
            this.Controls.Add(this.problemTypePanel);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.PentominosSourcePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.SolutionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionCounter)).EndInit();
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
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox SolutionView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton keyboardRadio;
        private System.Windows.Forms.NumericUpDown solutionCounter;
        private System.Windows.Forms.Button changeSolutionButton;
        private System.Windows.Forms.Label solutionsLabel;
    }
}

