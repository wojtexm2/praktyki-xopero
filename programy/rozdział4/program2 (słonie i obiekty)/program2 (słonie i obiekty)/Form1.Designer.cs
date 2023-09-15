namespace program2__słonie_i_obiekty_
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
            buttonLucinda = new Button();
            buttonZamien = new Button();
            buttonLloyd = new Button();
            SuspendLayout();
            // 
            // buttonLucinda
            // 
            buttonLucinda.Location = new Point(54, 41);
            buttonLucinda.Name = "buttonLucinda";
            buttonLucinda.Size = new Size(75, 23);
            buttonLucinda.TabIndex = 1;
            buttonLucinda.Text = "Lucinda";
            buttonLucinda.UseVisualStyleBackColor = true;
            buttonLucinda.Click += buttonLucinda_Click;
            // 
            // buttonZamien
            // 
            buttonZamien.Location = new Point(54, 70);
            buttonZamien.Name = "buttonZamien";
            buttonZamien.Size = new Size(75, 23);
            buttonZamien.TabIndex = 2;
            buttonZamien.Text = "Zamień!";
            buttonZamien.UseVisualStyleBackColor = true;
            buttonZamien.Click += buttonZamien_Click;
            // 
            // buttonLloyd
            // 
            buttonLloyd.Location = new Point(54, 12);
            buttonLloyd.Name = "buttonLloyd";
            buttonLloyd.Size = new Size(75, 23);
            buttonLloyd.TabIndex = 3;
            buttonLloyd.Text = "Lloyd";
            buttonLloyd.UseVisualStyleBackColor = true;
            buttonLloyd.Click += buttonLloyd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(191, 106);
            Controls.Add(buttonLloyd);
            Controls.Add(buttonZamien);
            Controls.Add(buttonLucinda);
            Name = "Form1";
            Text = "Zamiana";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonLucinda;
        private Button buttonZamien;
        private Button buttonLloyd;
    }
}