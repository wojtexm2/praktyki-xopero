namespace Śniadanie_dla_drwali
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
            name = new TextBox();
            label1 = new Label();
            buttonAdd = new Button();
            line = new ListBox();
            groupBox1 = new GroupBox();
            next = new Button();
            nextInLine = new TextBox();
            banana = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            browned = new RadioButton();
            crispy = new RadioButton();
            soggy = new RadioButton();
            label2 = new Label();
            addFlapjacks = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(106, 6);
            name.Name = "name";
            name.Size = new Size(189, 23);
            name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Imię drwala";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 35);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(283, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Dodaj drwala";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // line
            // 
            line.FormattingEnabled = true;
            line.ItemHeight = 15;
            line.Location = new Point(7, 92);
            line.Name = "line";
            line.Size = new Size(120, 349);
            line.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addFlapjacks);
            groupBox1.Controls.Add(next);
            groupBox1.Controls.Add(nextInLine);
            groupBox1.Controls.Add(banana);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(browned);
            groupBox1.Controls.Add(crispy);
            groupBox1.Controls.Add(soggy);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(138, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 349);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nakarm drwala";
            // 
            // next
            // 
            next.Location = new Point(6, 320);
            next.Name = "next";
            next.Size = new Size(168, 23);
            next.TabIndex = 9;
            next.Text = "Następny drwal";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // nextInLine
            // 
            nextInLine.Location = new Point(6, 180);
            nextInLine.Multiline = true;
            nextInLine.Name = "nextInLine";
            nextInLine.ReadOnly = true;
            nextInLine.Size = new Size(168, 85);
            nextInLine.TabIndex = 9;
            // 
            // banana
            // 
            banana.AutoSize = true;
            banana.Location = new Point(6, 126);
            banana.Name = "banana";
            banana.Size = new Size(94, 19);
            banana.TabIndex = 10;
            banana.Text = "Bananowego";
            banana.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 22);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(87, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // browned
            // 
            browned.AutoSize = true;
            browned.Location = new Point(6, 101);
            browned.Name = "browned";
            browned.Size = new Size(86, 19);
            browned.TabIndex = 9;
            browned.Text = "Rumianego";
            browned.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            crispy.AutoSize = true;
            crispy.Checked = true;
            crispy.Location = new Point(6, 51);
            crispy.Name = "crispy";
            crispy.Size = new Size(87, 19);
            crispy.TabIndex = 6;
            crispy.TabStop = true;
            crispy.Text = "Chrupkiego";
            crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            soggy.AutoSize = true;
            soggy.Location = new Point(6, 76);
            soggy.Name = "soggy";
            soggy.Size = new Size(87, 19);
            soggy.TabIndex = 8;
            soggy.Text = "Wilgotnego";
            soggy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 7;
            label2.Text = "Kolejka do śniadania";
            // 
            // addFlapjacks
            // 
            addFlapjacks.Location = new Point(6, 151);
            addFlapjacks.Name = "addFlapjacks";
            addFlapjacks.Size = new Size(168, 23);
            addFlapjacks.TabIndex = 8;
            addFlapjacks.Text = "Dodaj naleśnik";
            addFlapjacks.UseVisualStyleBackColor = true;
            addFlapjacks.Click += addFlapjacks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 450);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(line);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Śniadanie dla drwali";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label label1;
        private Button buttonAdd;
        private ListBox line;
        private GroupBox groupBox1;
        private RadioButton crispy;
        private Label label2;
        private RadioButton soggy;
        private RadioButton browned;
        private RadioButton banana;
        private Button next;
        private TextBox nextInLine;
        private NumericUpDown numericUpDown1;
        private Button addFlapjacks;
    }
}