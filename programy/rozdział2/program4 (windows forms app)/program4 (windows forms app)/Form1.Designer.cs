﻿namespace program4__windows_forms_app_
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kliknięcie zmienia etykietę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Location = new System.Drawing.Point(333, 16);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(139, 17);
            this.enableCheckbox.TabIndex = 1;
            this.enableCheckbox.Text = "Włącza zmianę etykiety";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(12, 59);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(460, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Naciśnij przycisk, aby zmienić tekst";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelToChange.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Test Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.Label labelToChange;
    }
}

