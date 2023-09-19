namespace Program_3__Planista_przyjęć_naprawiony_
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
            label1 = new Label();
            fancyBox = new CheckBox();
            healthyBox = new CheckBox();
            label2 = new Label();
            costLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            birthdayCost = new Label();
            label5 = new Label();
            cakeWriting = new TextBox();
            tooLongLabel = new Label();
            label4 = new Label();
            fancyBirthday = new CheckBox();
            numberBirthday = new NumericUpDown();
            label3 = new Label();
            tabPage1 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberBirthday).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ilość osób";
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Checked = true;
            fancyBox.CheckState = CheckState.Checked;
            fancyBox.Location = new Point(6, 50);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(135, 19);
            fancyBox.TabIndex = 1;
            fancyBox.Text = "Dekoracje fantazyjne";
            fancyBox.UseVisualStyleBackColor = true;
            fancyBox.CheckedChanged += fancyBox_CheckedChanged;
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(6, 75);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(98, 19);
            healthyBox.TabIndex = 3;
            healthyBox.Text = "Opcja zdrowa";
            healthyBox.UseVisualStyleBackColor = true;
            healthyBox.CheckedChanged += healthyBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Koszt";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.BorderStyle = BorderStyle.Fixed3D;
            costLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            costLabel.Location = new Point(50, 97);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(24, 17);
            costLabel.TabIndex = 5;
            costLabel.Text = "???";
            costLabel.Click += label3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 21);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(301, 209);
            tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(birthdayCost);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(cakeWriting);
            tabPage2.Controls.Add(tooLongLabel);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(fancyBirthday);
            tabPage2.Controls.Add(numberBirthday);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(293, 181);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przyjęcie urodzinowe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            birthdayCost.AutoSize = true;
            birthdayCost.BorderStyle = BorderStyle.Fixed3D;
            birthdayCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            birthdayCost.Location = new Point(54, 116);
            birthdayCost.Name = "birthdayCost";
            birthdayCost.Size = new Size(24, 17);
            birthdayCost.TabIndex = 7;
            birthdayCost.Text = "???";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 116);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "Koszt";
            // 
            // cakeWriting
            // 
            cakeWriting.Location = new Point(7, 90);
            cakeWriting.Name = "cakeWriting";
            cakeWriting.Size = new Size(161, 23);
            cakeWriting.TabIndex = 5;
            cakeWriting.Text = "Sto lat!";
            cakeWriting.TextChanged += cakeWriting_TextChanged;
            // 
            // tooLongLabel
            // 
            tooLongLabel.AutoSize = true;
            tooLongLabel.BackColor = Color.Red;
            tooLongLabel.Location = new Point(98, 72);
            tooLongLabel.Name = "tooLongLabel";
            tooLongLabel.Size = new Size(70, 15);
            tooLongLabel.TabIndex = 4;
            tooLongLabel.Text = "ZBYT DŁUGI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Napis na torcie";
            // 
            // fancyBirthday
            // 
            fancyBirthday.AutoSize = true;
            fancyBirthday.Checked = true;
            fancyBirthday.CheckState = CheckState.Checked;
            fancyBirthday.Location = new Point(7, 50);
            fancyBirthday.Name = "fancyBirthday";
            fancyBirthday.Size = new Size(135, 19);
            fancyBirthday.TabIndex = 2;
            fancyBirthday.Text = "Dekoracje fantazyjne";
            fancyBirthday.UseVisualStyleBackColor = true;
            fancyBirthday.CheckedChanged += fancyBirthday_CheckedChanged;
            // 
            // numberBirthday
            // 
            numberBirthday.Location = new Point(7, 21);
            numberBirthday.Name = "numberBirthday";
            numberBirthday.Size = new Size(75, 23);
            numberBirthday.TabIndex = 1;
            numberBirthday.ValueChanged += numberBirthday_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 3);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Ilość osób";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(fancyBox);
            tabPage1.Controls.Add(costLabel);
            tabPage1.Controls.Add(healthyBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(293, 181);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Impreza okolicznościowa";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 209);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Planista przyjęć 2.0";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberBirthday).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CheckBox fancyBox;
        private CheckBox healthyBox;
        private Label label2;
        private Label costLabel;
        private NumericUpDown numericUpDown1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private CheckBox fancyBirthday;
        private NumericUpDown numberBirthday;
        private Label label3;
        private Label tooLongLabel;
        private Label label4;
        private TextBox cakeWriting;
        private Label birthdayCost;
        private Label label5;
    }
}