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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
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
            fancyBox.Location = new Point(12, 56);
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
            healthyBox.Location = new Point(12, 81);
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
            label2.Location = new Point(12, 103);
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
            costLabel.Location = new Point(56, 103);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(24, 17);
            costLabel.TabIndex = 5;
            costLabel.Text = "???";
            costLabel.Click += label3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 27);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(158, 130);
            Controls.Add(numericUpDown1);
            Controls.Add(costLabel);
            Controls.Add(label2);
            Controls.Add(healthyBox);
            Controls.Add(fancyBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "o";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox fancyBox;
        private CheckBox healthyBox;
        private Label label2;
        private Label costLabel;
        private NumericUpDown numericUpDown1;
    }
}