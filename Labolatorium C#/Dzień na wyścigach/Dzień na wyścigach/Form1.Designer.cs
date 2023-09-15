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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            minimumBetLabel = new Label();
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
            numericUpDownBet = new NumericUpDown();
            label3 = new Label();
            numericUpDownDogId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDogId).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 22);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 5;
            label1.Text = "Dom bukmacherski";
            // 
            // minimumBetLabel
            // 
            minimumBetLabel.AutoSize = true;
            minimumBetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minimumBetLabel.Location = new Point(12, 252);
            minimumBetLabel.Name = "minimumBetLabel";
            minimumBetLabel.Size = new Size(109, 15);
            minimumBetLabel.TabIndex = 6;
            minimumBetLabel.Text = "minimumBetLabel";
            minimumBetLabel.Click += minimumBetLabel_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(460, 261);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(143, 96);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Start!";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(167, 252);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Zakłady";
            // 
            // firstBetLabel
            // 
            firstBetLabel.AutoSize = true;
            firstBetLabel.Location = new Point(167, 276);
            firstBetLabel.Name = "firstBetLabel";
            firstBetLabel.Size = new Size(68, 15);
            firstBetLabel.TabIndex = 9;
            firstBetLabel.Text = "joeBetLabel";
            // 
            // secondBetLabel
            // 
            secondBetLabel.AutoSize = true;
            secondBetLabel.Location = new Point(167, 302);
            secondBetLabel.Name = "secondBetLabel";
            secondBetLabel.Size = new Size(73, 15);
            secondBetLabel.TabIndex = 10;
            secondBetLabel.Text = "bobBetLabel";
            // 
            // thirdBetLabel
            // 
            thirdBetLabel.AutoSize = true;
            thirdBetLabel.Location = new Point(167, 329);
            thirdBetLabel.Name = "thirdBetLabel";
            thirdBetLabel.Size = new Size(74, 15);
            thirdBetLabel.TabIndex = 11;
            thirdBetLabel.Text = "arekBetLabel";
            // 
            // firstRadioButton
            // 
            firstRadioButton.AutoSize = true;
            firstRadioButton.Location = new Point(12, 276);
            firstRadioButton.Name = "firstRadioButton";
            firstRadioButton.Size = new Size(107, 19);
            firstRadioButton.TabIndex = 12;
            firstRadioButton.TabStop = true;
            firstRadioButton.Text = "joeRadioButton";
            firstRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondRadioButton
            // 
            secondRadioButton.AutoSize = true;
            secondRadioButton.Location = new Point(12, 302);
            secondRadioButton.Name = "secondRadioButton";
            secondRadioButton.Size = new Size(112, 19);
            secondRadioButton.TabIndex = 13;
            secondRadioButton.TabStop = true;
            secondRadioButton.Text = "bobRadioButton";
            secondRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdRadioButton
            // 
            thirdRadioButton.AutoSize = true;
            thirdRadioButton.Location = new Point(12, 329);
            thirdRadioButton.Name = "thirdRadioButton";
            thirdRadioButton.Size = new Size(113, 19);
            thirdRadioButton.TabIndex = 14;
            thirdRadioButton.TabStop = true;
            thirdRadioButton.Text = "arekRadioButton";
            thirdRadioButton.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(22, 368);
            labelName.Name = "labelName";
            labelName.Size = new Size(37, 15);
            labelName.TabIndex = 15;
            labelName.Text = "name";
            // 
            // buttonBet
            // 
            buttonBet.Location = new Point(98, 364);
            buttonBet.Name = "buttonBet";
            buttonBet.Size = new Size(54, 23);
            buttonBet.TabIndex = 16;
            buttonBet.Text = "stawia";
            buttonBet.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBet
            // 
            numericUpDownBet.Location = new Point(167, 366);
            numericUpDownBet.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDownBet.Name = "numericUpDownBet";
            numericUpDownBet.Size = new Size(50, 23);
            numericUpDownBet.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 368);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 18;
            label3.Text = "zł na charta numer";
            // 
            // numericUpDownDogId
            // 
            numericUpDownDogId.Location = new Point(334, 364);
            numericUpDownDogId.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownDogId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDogId.Name = "numericUpDownDogId";
            numericUpDownDogId.Size = new Size(39, 23);
            numericUpDownDogId.TabIndex = 19;
            numericUpDownDogId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 402);
            Controls.Add(numericUpDownDogId);
            Controls.Add(label3);
            Controls.Add(numericUpDownBet);
            Controls.Add(buttonBet);
            Controls.Add(labelName);
            Controls.Add(thirdRadioButton);
            Controls.Add(secondRadioButton);
            Controls.Add(firstRadioButton);
            Controls.Add(thirdBetLabel);
            Controls.Add(secondBetLabel);
            Controls.Add(firstBetLabel);
            Controls.Add(label2);
            Controls.Add(buttonStart);
            Controls.Add(minimumBetLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Dzień na wyścigach";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDogId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Label minimumBetLabel;
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
        private NumericUpDown numericUpDownBet;
        private Label label3;
        private NumericUpDown numericUpDownDogId;
    }
}