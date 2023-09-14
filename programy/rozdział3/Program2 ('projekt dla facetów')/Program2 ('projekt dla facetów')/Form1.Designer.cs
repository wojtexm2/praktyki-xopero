namespace Program2___projekt_dla_facetów__
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
            bankCashLabel = new Label();
            bobsCashLabel = new Label();
            joesCashLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // bankCashLabel
            // 
            bankCashLabel.AutoSize = true;
            bankCashLabel.Location = new Point(12, 69);
            bankCashLabel.Name = "bankCashLabel";
            bankCashLabel.Size = new Size(85, 15);
            bankCashLabel.TabIndex = 0;
            bankCashLabel.Text = "Bank ma 100 zł";
            // 
            // bobsCashLabel
            // 
            bobsCashLabel.AutoSize = true;
            bobsCashLabel.Location = new Point(12, 39);
            bobsCashLabel.Name = "bobsCashLabel";
            bobsCashLabel.Size = new Size(80, 15);
            bobsCashLabel.TabIndex = 1;
            bobsCashLabel.Text = "Bob ma 100 zł";
            // 
            // joesCashLabel
            // 
            joesCashLabel.AutoSize = true;
            joesCashLabel.Location = new Point(12, 9);
            joesCashLabel.Name = "joesCashLabel";
            joesCashLabel.Size = new Size(70, 15);
            joesCashLabel.TabIndex = 2;
            joesCashLabel.Text = "Joe ma 50 zł";
            // 
            // button1
            // 
            button1.Location = new Point(12, 98);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 3;
            button1.Text = "Daj 10 zł Joemu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 98);
            button2.Name = "button2";
            button2.Size = new Size(107, 39);
            button2.TabIndex = 4;
            button2.Text = "Weź 5 zł od Boba";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 152);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(joesCashLabel);
            Controls.Add(bobsCashLabel);
            Controls.Add(bankCashLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bankCashLabel;
        private Label bobsCashLabel;
        private Label joesCashLabel;
        private Button button1;
        private Button button2;
    }
}