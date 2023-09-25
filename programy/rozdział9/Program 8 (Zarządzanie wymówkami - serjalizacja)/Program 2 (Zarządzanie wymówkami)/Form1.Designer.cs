namespace Program_2__Zarządzanie_wymówkami_
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            description = new TextBox();
            results = new TextBox();
            fileDate = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            folder = new Button();
            save = new Button();
            open = new Button();
            randomExcuse = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Wymówka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Wyniki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Data pliku";
            // 
            // description
            // 
            description.Location = new Point(101, 6);
            description.Name = "description";
            description.Size = new Size(421, 23);
            description.TabIndex = 4;
            description.TextChanged += description_TextChanged;
            // 
            // results
            // 
            results.Location = new Point(101, 35);
            results.Name = "results";
            results.Size = new Size(421, 23);
            results.TabIndex = 5;
            results.TextChanged += results_TextChanged;
            // 
            // fileDate
            // 
            fileDate.Location = new Point(101, 93);
            fileDate.Name = "fileDate";
            fileDate.ReadOnly = true;
            fileDate.Size = new Size(421, 23);
            fileDate.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(421, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // folder
            // 
            folder.Location = new Point(12, 132);
            folder.Name = "folder";
            folder.Size = new Size(75, 23);
            folder.TabIndex = 9;
            folder.Text = "Folder";
            folder.UseVisualStyleBackColor = true;
            folder.Click += folder_Click;
            // 
            // save
            // 
            save.Enabled = false;
            save.Location = new Point(93, 132);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 10;
            save.Text = "Zapisz";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // open
            // 
            open.Enabled = false;
            open.Location = new Point(174, 132);
            open.Name = "open";
            open.Size = new Size(75, 23);
            open.TabIndex = 11;
            open.Text = "Otwórz";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // randomExcuse
            // 
            randomExcuse.Enabled = false;
            randomExcuse.Location = new Point(255, 132);
            randomExcuse.Name = "randomExcuse";
            randomExcuse.Size = new Size(267, 23);
            randomExcuse.TabIndex = 12;
            randomExcuse.Text = "Losowa wymówka";
            randomExcuse.UseVisualStyleBackColor = true;
            randomExcuse.Click += randomExcuse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 171);
            Controls.Add(randomExcuse);
            Controls.Add(open);
            Controls.Add(save);
            Controls.Add(folder);
            Controls.Add(dateTimePicker1);
            Controls.Add(fileDate);
            Controls.Add(results);
            Controls.Add(description);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Program do zarządzania wymówkami";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox description;
        private TextBox results;
        private TextBox fileDate;
        private DateTimePicker dateTimePicker1;
        private Button folder;
        private Button save;
        private Button open;
        private Button randomExcuse;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}