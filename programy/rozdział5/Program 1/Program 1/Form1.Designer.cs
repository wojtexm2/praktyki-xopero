namespace Program_1
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
            numericUpDownIloscOsob = new NumericUpDown();
            checkBoxDekoracjeFantazyjne = new CheckBox();
            checkBoxOpcjaZdrowa = new CheckBox();
            label2 = new Label();
            labelKoszt = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIloscOsob).BeginInit();
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
            // numericUpDownIloscOsob
            // 
            numericUpDownIloscOsob.Location = new Point(12, 27);
            numericUpDownIloscOsob.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownIloscOsob.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownIloscOsob.Name = "numericUpDownIloscOsob";
            numericUpDownIloscOsob.Size = new Size(104, 23);
            numericUpDownIloscOsob.TabIndex = 1;
            numericUpDownIloscOsob.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownIloscOsob.ValueChanged += numericUpDownIloscOsob_ValueChanged;
            // 
            // checkBoxDekoracjeFantazyjne
            // 
            checkBoxDekoracjeFantazyjne.AutoSize = true;
            checkBoxDekoracjeFantazyjne.Location = new Point(12, 56);
            checkBoxDekoracjeFantazyjne.Name = "checkBoxDekoracjeFantazyjne";
            checkBoxDekoracjeFantazyjne.Size = new Size(135, 19);
            checkBoxDekoracjeFantazyjne.TabIndex = 2;
            checkBoxDekoracjeFantazyjne.Text = "Dekoracje fantazyjne";
            checkBoxDekoracjeFantazyjne.UseVisualStyleBackColor = true;
            checkBoxDekoracjeFantazyjne.CheckedChanged += checkBoxDekoracjeFantazyjne_CheckedChanged;
            // 
            // checkBoxOpcjaZdrowa
            // 
            checkBoxOpcjaZdrowa.AutoSize = true;
            checkBoxOpcjaZdrowa.Location = new Point(12, 81);
            checkBoxOpcjaZdrowa.Name = "checkBoxOpcjaZdrowa";
            checkBoxOpcjaZdrowa.Size = new Size(98, 19);
            checkBoxOpcjaZdrowa.TabIndex = 5;
            checkBoxOpcjaZdrowa.Text = "Opcja zdrowa";
            checkBoxOpcjaZdrowa.UseVisualStyleBackColor = true;
            checkBoxOpcjaZdrowa.CheckedChanged += checkBoxOpcjaZdrowa_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Koszt";
            // 
            // labelKoszt
            // 
            labelKoszt.AutoSize = true;
            labelKoszt.BorderStyle = BorderStyle.Fixed3D;
            labelKoszt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelKoszt.Location = new Point(56, 103);
            labelKoszt.Name = "labelKoszt";
            labelKoszt.Size = new Size(60, 17);
            labelKoszt.TabIndex = 6;
            labelKoszt.Text = "000.00 zł";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(164, 135);
            Controls.Add(labelKoszt);
            Controls.Add(checkBoxOpcjaZdrowa);
            Controls.Add(label2);
            Controls.Add(checkBoxDekoracjeFantazyjne);
            Controls.Add(numericUpDownIloscOsob);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Planista przyjęć";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownIloscOsob).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownIloscOsob;
        private CheckBox checkBoxDekoracjeFantazyjne;
        private CheckBox checkBoxOpcjaZdrowa;
        private Label label2;
        private Label labelKoszt;
    }
}