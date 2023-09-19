namespace Program_4__System_zarządzania_ulem_
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
            groupBox1 = new GroupBox();
            assignJob = new Button();
            shifts = new NumericUpDown();
            workerBeeJob = new ComboBox();
            label1 = new Label();
            nextShift = new Button();
            report = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(assignJob);
            groupBox1.Controls.Add(shifts);
            groupBox1.Controls.Add(workerBeeJob);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Przydział prac robotnicom";
            // 
            // assignJob
            // 
            assignJob.Location = new Point(6, 65);
            assignJob.Name = "assignJob";
            assignJob.Size = new Size(247, 23);
            assignJob.TabIndex = 2;
            assignJob.Text = "Przypisz tę pracę pszczole";
            assignJob.UseVisualStyleBackColor = true;
            assignJob.Click += assignJob_Click;
            // 
            // shifts
            // 
            shifts.Location = new Point(133, 37);
            shifts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            shifts.Name = "shifts";
            shifts.Size = new Size(120, 23);
            shifts.TabIndex = 4;
            shifts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // workerBeeJob
            // 
            workerBeeJob.DropDownStyle = ComboBoxStyle.DropDownList;
            workerBeeJob.FormattingEnabled = true;
            workerBeeJob.Items.AddRange(new object[] { "Nauczanie pszczółek", "Pielęgnacja jaj", "Utrzymanie ula", "Wytwarzanie miodu", "Zbieranie nektaru", "Patrol z żądłami" });
            workerBeeJob.Location = new Point(6, 37);
            workerBeeJob.Name = "workerBeeJob";
            workerBeeJob.Size = new Size(121, 23);
            workerBeeJob.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Zadanie robotnicy";
            // 
            // nextShift
            // 
            nextShift.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nextShift.Location = new Point(291, 12);
            nextShift.Name = "nextShift";
            nextShift.Size = new Size(142, 100);
            nextShift.TabIndex = 1;
            nextShift.Text = "Przepracuj następną zmianę";
            nextShift.UseVisualStyleBackColor = true;
            nextShift.Click += nextShift_Click;
            // 
            // report
            // 
            report.Location = new Point(12, 118);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(421, 222);
            report.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 353);
            Controls.Add(report);
            Controls.Add(nextShift);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "System zarządzania ulem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox workerBeeJob;
        private Label label1;
        private Button nextShift;
        private Button assignJob;
        private NumericUpDown shifts;
        private TextBox report;
    }
}