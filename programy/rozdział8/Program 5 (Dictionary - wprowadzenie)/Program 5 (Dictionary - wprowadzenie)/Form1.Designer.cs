namespace Program_5__Dictionary___wprowadzenie_
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
            number = new ComboBox();
            label2 = new Label();
            labelPlayer = new Label();
            label4 = new Label();
            label3 = new Label();
            labelYear = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Numer";
            // 
            // number
            // 
            number.DropDownStyle = ComboBoxStyle.DropDownList;
            number.FormattingEnabled = true;
            number.Location = new Point(62, 6);
            number.Name = "number";
            number.Size = new Size(64, 23);
            number.TabIndex = 1;
            number.SelectedIndexChanged += number_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "należał do gracza";
            // 
            // labelPlayer
            // 
            labelPlayer.BorderStyle = BorderStyle.Fixed3D;
            labelPlayer.Location = new Point(235, 9);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(112, 20);
            labelPlayer.TabIndex = 3;
            labelPlayer.Text = "??????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 11);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "roku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 10);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 5;
            label3.Text = ", który zakończył karierę w";
            // 
            // labelYear
            // 
            labelYear.BorderStyle = BorderStyle.Fixed3D;
            labelYear.Location = new Point(503, 10);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(38, 20);
            labelYear.TabIndex = 6;
            labelYear.Text = "????";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 44);
            Controls.Add(labelYear);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(labelPlayer);
            Controls.Add(label2);
            Controls.Add(number);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Numery koszulek sławnych zawodników";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox number;
        private Label label2;
        private Label labelPlayer;
        private Label label4;
        private Label label3;
        private Label labelYear;
    }
}