namespace Dzień_na_wyścigach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBoxHound1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            buttonStart = new Button();
            label2 = new Label();
            firstBetLabel = new Label();
            secondBetLabel = new Label();
            thirdBetLabel = new Label();
            firstRadioButton = new RadioButton();
            secondRadioButton = new RadioButton();
            thirdRadioButton = new RadioButton();
            labelName = new Label();
            buttonBet = new Button();
            label3 = new Label();
            numericUpDownDogId = new NumericUpDown();
            houndTimer = new System.Windows.Forms.Timer(components);
            minimumBetLabel = new Label();
            groupBox1 = new GroupBox();
            betAmmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHound1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDogId).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)betAmmount).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(601, 201);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxHound1
            // 
            pictureBoxHound1.Image = (Image)resources.GetObject("pictureBoxHound1.Image");
            pictureBoxHound1.Location = new Point(22, 21);
            pictureBoxHound1.Name = "pictureBoxHound1";
            pictureBoxHound1.Size = new Size(76, 22);
            pictureBoxHound1.TabIndex = 1;
            pictureBoxHound1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 22);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 125);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(76, 22);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(22, 178);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 22);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(446, 37);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(143, 96);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Start!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(185, 26);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Zakłady";
            // 
            // firstBetLabel
            // 
            firstBetLabel.BorderStyle = BorderStyle.FixedSingle;
            firstBetLabel.Location = new Point(185, 48);
            firstBetLabel.Name = "firstBetLabel";
            firstBetLabel.Size = new Size(235, 17);
            firstBetLabel.TabIndex = 9;
            firstBetLabel.Text = "joeBetLabel";
            // 
            // secondBetLabel
            // 
            secondBetLabel.BorderStyle = BorderStyle.FixedSingle;
            secondBetLabel.Location = new Point(185, 72);
            secondBetLabel.Name = "secondBetLabel";
            secondBetLabel.Size = new Size(235, 15);
            secondBetLabel.TabIndex = 10;
            secondBetLabel.Text = "bobBetLabel";
            // 
            // thirdBetLabel
            // 
            thirdBetLabel.BorderStyle = BorderStyle.FixedSingle;
            thirdBetLabel.Location = new Point(184, 97);
            thirdBetLabel.Name = "thirdBetLabel";
            thirdBetLabel.Size = new Size(236, 17);
            thirdBetLabel.TabIndex = 11;
            thirdBetLabel.Text = "arekBetLabel";
            // 
            // firstRadioButton
            // 
            firstRadioButton.AutoSize = true;
            firstRadioButton.Location = new Point(10, 48);
            firstRadioButton.Name = "firstRadioButton";
            firstRadioButton.Size = new Size(95, 19);
            firstRadioButton.TabIndex = 12;
            firstRadioButton.TabStop = true;
            firstRadioButton.Text = "Guy 1 ma x zł";
            firstRadioButton.UseVisualStyleBackColor = true;
            firstRadioButton.CheckedChanged += firstRadioButton_CheckedChanged;
            // 
            // secondRadioButton
            // 
            secondRadioButton.AutoSize = true;
            secondRadioButton.Location = new Point(10, 72);
            secondRadioButton.Name = "secondRadioButton";
            secondRadioButton.Size = new Size(95, 19);
            secondRadioButton.TabIndex = 13;
            secondRadioButton.TabStop = true;
            secondRadioButton.Text = "Guy 2 ma x zł";
            secondRadioButton.UseVisualStyleBackColor = true;
            secondRadioButton.CheckedChanged += secondRadioButton_CheckedChanged;
            // 
            // thirdRadioButton
            // 
            thirdRadioButton.AutoSize = true;
            thirdRadioButton.Location = new Point(10, 97);
            thirdRadioButton.Name = "thirdRadioButton";
            thirdRadioButton.Size = new Size(95, 19);
            thirdRadioButton.TabIndex = 14;
            thirdRadioButton.TabStop = true;
            thirdRadioButton.Text = "Guy 3 ma x zł";
            thirdRadioButton.UseVisualStyleBackColor = true;
            thirdRadioButton.CheckedChanged += thirdRadioButton_CheckedChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(10, 138);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 15);
            labelName.TabIndex = 15;
            labelName.Text = "Nikt nie";
            // 
            // buttonBet
            // 
            buttonBet.Location = new Point(64, 134);
            buttonBet.Name = "buttonBet";
            buttonBet.Size = new Size(68, 23);
            buttonBet.TabIndex = 16;
            buttonBet.Text = "stawia";
            buttonBet.UseVisualStyleBackColor = true;
            buttonBet.Click += buttonBet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 138);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 18;
            label3.Text = "zł na charta numer";
            // 
            // numericUpDownDogId
            // 
            numericUpDownDogId.Location = new Point(322, 136);
            numericUpDownDogId.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownDogId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDogId.Name = "numericUpDownDogId";
            numericUpDownDogId.Size = new Size(39, 23);
            numericUpDownDogId.TabIndex = 19;
            numericUpDownDogId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // houndTimer
            // 
            houndTimer.Interval = 50;
            houndTimer.Tick += houndTimer_Tick;
            // 
            // minimumBetLabel
            // 
            minimumBetLabel.AutoSize = true;
            minimumBetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minimumBetLabel.Location = new Point(6, 26);
            minimumBetLabel.Name = "minimumBetLabel";
            minimumBetLabel.Size = new Size(126, 15);
            minimumBetLabel.TabIndex = 20;
            minimumBetLabel.Text = "Minimalny zakład 5 zł";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(betAmmount);
            groupBox1.Controls.Add(numericUpDownDogId);
            groupBox1.Controls.Add(minimumBetLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(firstRadioButton);
            groupBox1.Controls.Add(secondRadioButton);
            groupBox1.Controls.Add(buttonBet);
            groupBox1.Controls.Add(thirdRadioButton);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(buttonStart);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(thirdBetLabel);
            groupBox1.Controls.Add(firstBetLabel);
            groupBox1.Controls.Add(secondBetLabel);
            groupBox1.Location = new Point(12, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 165);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dom bukmacherski";
            // 
            // betAmmount
            // 
            betAmmount.Location = new Point(138, 136);
            betAmmount.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            betAmmount.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            betAmmount.Name = "betAmmount";
            betAmmount.Size = new Size(67, 23);
            betAmmount.TabIndex = 21;
            betAmmount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 402);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBoxHound1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Dzień na wyścigach";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHound1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDogId).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)betAmmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBoxHound1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button buttonStart;
        private Label label2;
        private Label firstBetLabel;
        private Label secondBetLabel;
        private Label thirdBetLabel;
        private RadioButton firstRadioButton;
        private RadioButton secondRadioButton;
        private RadioButton thirdRadioButton;
        private Label labelName;
        private Button buttonBet;
        private Label label3;
        private NumericUpDown numericUpDownDogId;
        private System.Windows.Forms.Timer houndTimer;
        private Label minimumBetLabel;
        private GroupBox groupBox1;
        private NumericUpDown betAmmount;
    }
}