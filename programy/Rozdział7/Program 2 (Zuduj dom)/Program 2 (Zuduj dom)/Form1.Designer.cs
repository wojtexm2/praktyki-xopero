namespace Program_2__Zuduj_dom_
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
            description = new TextBox();
            goHere = new Button();
            goThroughTheDoor = new Button();
            exits = new ComboBox();
            SuspendLayout();
            // 
            // description
            // 
            description.Location = new Point(12, 12);
            description.Multiline = true;
            description.Name = "description";
            description.ReadOnly = true;
            description.Size = new Size(280, 146);
            description.TabIndex = 0;
            // 
            // goHere
            // 
            goHere.Location = new Point(12, 164);
            goHere.Name = "goHere";
            goHere.Size = new Size(75, 23);
            goHere.TabIndex = 1;
            goHere.Text = "Idź tutaj:";
            goHere.UseVisualStyleBackColor = true;
            goHere.Click += button1_Click;
            // 
            // goThroughTheDoor
            // 
            goThroughTheDoor.Location = new Point(12, 193);
            goThroughTheDoor.Name = "goThroughTheDoor";
            goThroughTheDoor.Size = new Size(280, 23);
            goThroughTheDoor.TabIndex = 2;
            goThroughTheDoor.Text = "Przejdź przez drzwi";
            goThroughTheDoor.UseVisualStyleBackColor = true;
            // 
            // exits
            // 
            exits.DropDownStyle = ComboBoxStyle.DropDownList;
            exits.FormattingEnabled = true;
            exits.Location = new Point(93, 164);
            exits.Name = "exits";
            exits.Size = new Size(199, 23);
            exits.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 232);
            Controls.Add(exits);
            Controls.Add(goThroughTheDoor);
            Controls.Add(goHere);
            Controls.Add(description);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Dom";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox description;
        private Button goHere;
        private Button goThroughTheDoor;
        private ComboBox exits;
    }
}