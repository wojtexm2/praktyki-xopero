namespace program1_zwrot_kosztów_
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
            poczStanLicznika = new NumericUpDown();
            konStanLicznika = new NumericUpDown();
            poczStanLicznikaLabel = new Label();
            konStanLicznikaLabel = new Label();
            kosztaDoZwrotuLabel = new Label();
            kosztaDoZwrotuLabelWyswietl = new Label();
            obliczButton = new Button();
            ((System.ComponentModel.ISupportInitialize)poczStanLicznika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)konStanLicznika).BeginInit();
            SuspendLayout();
            // 
            // poczStanLicznika
            // 
            poczStanLicznika.Location = new Point(155, 9);
            poczStanLicznika.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            poczStanLicznika.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            poczStanLicznika.Name = "poczStanLicznika";
            poczStanLicznika.Size = new Size(120, 23);
            poczStanLicznika.TabIndex = 0;
            // 
            // konStanLicznika
            // 
            konStanLicznika.Location = new Point(155, 38);
            konStanLicznika.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            konStanLicznika.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            konStanLicznika.Name = "konStanLicznika";
            konStanLicznika.Size = new Size(120, 23);
            konStanLicznika.TabIndex = 1;
            // 
            // poczStanLicznikaLabel
            // 
            poczStanLicznikaLabel.AutoSize = true;
            poczStanLicznikaLabel.Location = new Point(12, 9);
            poczStanLicznikaLabel.Name = "poczStanLicznikaLabel";
            poczStanLicznikaLabel.Size = new Size(137, 15);
            poczStanLicznikaLabel.TabIndex = 2;
            poczStanLicznikaLabel.Text = "Początkowy stan licznika";
            // 
            // konStanLicznikaLabel
            // 
            konStanLicznikaLabel.AutoSize = true;
            konStanLicznikaLabel.Location = new Point(12, 38);
            konStanLicznikaLabel.Name = "konStanLicznikaLabel";
            konStanLicznikaLabel.Size = new Size(123, 15);
            konStanLicznikaLabel.TabIndex = 3;
            konStanLicznikaLabel.Text = "Końcowy stan licznika";
            // 
            // kosztaDoZwrotuLabel
            // 
            kosztaDoZwrotuLabel.AutoSize = true;
            kosztaDoZwrotuLabel.Location = new Point(12, 78);
            kosztaDoZwrotuLabel.Name = "kosztaDoZwrotuLabel";
            kosztaDoZwrotuLabel.Size = new Size(97, 15);
            kosztaDoZwrotuLabel.TabIndex = 4;
            kosztaDoZwrotuLabel.Text = "Koszta do zwrotu";
            // 
            // kosztaDoZwrotuLabelWyswietl
            // 
            kosztaDoZwrotuLabelWyswietl.AutoSize = true;
            kosztaDoZwrotuLabelWyswietl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kosztaDoZwrotuLabelWyswietl.Location = new Point(115, 72);
            kosztaDoZwrotuLabelWyswietl.Name = "kosztaDoZwrotuLabelWyswietl";
            kosztaDoZwrotuLabelWyswietl.Size = new Size(31, 21);
            kosztaDoZwrotuLabelWyswietl.TabIndex = 5;
            kosztaDoZwrotuLabelWyswietl.Text = "???";
            kosztaDoZwrotuLabelWyswietl.Click += kosztaDoZwrotuLabelWyswietl_Click;
            // 
            // obliczButton
            // 
            obliczButton.Location = new Point(106, 102);
            obliczButton.Name = "obliczButton";
            obliczButton.Size = new Size(75, 23);
            obliczButton.TabIndex = 6;
            obliczButton.Text = "Oblicz";
            obliczButton.UseVisualStyleBackColor = true;
            obliczButton.Click += obliczButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 137);
            Controls.Add(obliczButton);
            Controls.Add(kosztaDoZwrotuLabelWyswietl);
            Controls.Add(kosztaDoZwrotuLabel);
            Controls.Add(konStanLicznikaLabel);
            Controls.Add(poczStanLicznikaLabel);
            Controls.Add(konStanLicznika);
            Controls.Add(poczStanLicznika);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Kalkulator odległości";
            ((System.ComponentModel.ISupportInitialize)poczStanLicznika).EndInit();
            ((System.ComponentModel.ISupportInitialize)konStanLicznika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown poczStanLicznika;
        private NumericUpDown konStanLicznika;
        private Label poczStanLicznikaLabel;
        private Label konStanLicznikaLabel;
        private Label kosztaDoZwrotuLabel;
        private Label kosztaDoZwrotuLabelWyswietl;
        private Button obliczButton;
    }
}