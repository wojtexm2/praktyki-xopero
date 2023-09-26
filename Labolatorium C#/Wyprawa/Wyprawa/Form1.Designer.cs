namespace Wyprawa
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
            playerBox = new PictureBox();
            batBox = new PictureBox();
            ghostBox = new PictureBox();
            ghoulBox = new PictureBox();
            redPotionBox = new PictureBox();
            bluePotionBox = new PictureBox();
            swordBox = new PictureBox();
            bowBox = new PictureBox();
            maceBox = new PictureBox();
            slot1 = new PictureBox();
            slot2 = new PictureBox();
            slot3 = new PictureBox();
            slot4 = new PictureBox();
            slot5 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ghoulHitPoints = new Label();
            ghostHitPoints = new Label();
            batHitPoints = new Label();
            label3 = new Label();
            playerHitPoints = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            goUp = new Button();
            goDown = new Button();
            goLeft = new Button();
            goRight = new Button();
            label10 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)batBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghostBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghoulBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redPotionBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bluePotionBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swordBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bowBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot5).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // playerBox
            // 
            playerBox.BackColor = Color.Transparent;
            playerBox.BackgroundImageLayout = ImageLayout.Stretch;
            playerBox.Image = Properties.Resources.player;
            playerBox.Location = new Point(240, 129);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(30, 30);
            playerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playerBox.TabIndex = 0;
            playerBox.TabStop = false;
            // 
            // batBox
            // 
            batBox.BackColor = Color.Transparent;
            batBox.BackgroundImageLayout = ImageLayout.Stretch;
            batBox.Image = Properties.Resources.bat;
            batBox.Location = new Point(108, 49);
            batBox.Name = "batBox";
            batBox.Size = new Size(30, 30);
            batBox.SizeMode = PictureBoxSizeMode.StretchImage;
            batBox.TabIndex = 1;
            batBox.TabStop = false;
            batBox.Visible = false;
            // 
            // ghostBox
            // 
            ghostBox.BackColor = Color.Transparent;
            ghostBox.BackgroundImageLayout = ImageLayout.Stretch;
            ghostBox.Image = Properties.Resources.ghost;
            ghostBox.Location = new Point(144, 49);
            ghostBox.Name = "ghostBox";
            ghostBox.Size = new Size(30, 30);
            ghostBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ghostBox.TabIndex = 2;
            ghostBox.TabStop = false;
            ghostBox.Visible = false;
            // 
            // ghoulBox
            // 
            ghoulBox.BackColor = Color.Transparent;
            ghoulBox.BackgroundImageLayout = ImageLayout.Stretch;
            ghoulBox.Image = Properties.Resources.ghoul;
            ghoulBox.Location = new Point(180, 49);
            ghoulBox.Name = "ghoulBox";
            ghoulBox.Size = new Size(30, 30);
            ghoulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ghoulBox.TabIndex = 3;
            ghoulBox.TabStop = false;
            ghoulBox.Visible = false;
            // 
            // redPotionBox
            // 
            redPotionBox.BackColor = Color.Transparent;
            redPotionBox.BackgroundImageLayout = ImageLayout.Stretch;
            redPotionBox.Image = Properties.Resources.potion_red;
            redPotionBox.Location = new Point(216, 49);
            redPotionBox.Name = "redPotionBox";
            redPotionBox.Size = new Size(30, 30);
            redPotionBox.SizeMode = PictureBoxSizeMode.StretchImage;
            redPotionBox.TabIndex = 4;
            redPotionBox.TabStop = false;
            redPotionBox.Visible = false;
            // 
            // bluePotionBox
            // 
            bluePotionBox.BackColor = Color.Transparent;
            bluePotionBox.BackgroundImageLayout = ImageLayout.Stretch;
            bluePotionBox.Image = Properties.Resources.potion_blue;
            bluePotionBox.Location = new Point(252, 49);
            bluePotionBox.Name = "bluePotionBox";
            bluePotionBox.Size = new Size(30, 30);
            bluePotionBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bluePotionBox.TabIndex = 5;
            bluePotionBox.TabStop = false;
            bluePotionBox.Visible = false;
            // 
            // swordBox
            // 
            swordBox.BackColor = Color.Transparent;
            swordBox.BackgroundImageLayout = ImageLayout.Stretch;
            swordBox.Image = Properties.Resources.sword;
            swordBox.Location = new Point(288, 49);
            swordBox.Name = "swordBox";
            swordBox.Size = new Size(30, 30);
            swordBox.SizeMode = PictureBoxSizeMode.StretchImage;
            swordBox.TabIndex = 6;
            swordBox.TabStop = false;
            swordBox.Visible = false;
            // 
            // bowBox
            // 
            bowBox.BackColor = Color.Transparent;
            bowBox.BackgroundImageLayout = ImageLayout.Stretch;
            bowBox.Image = Properties.Resources.bow;
            bowBox.Location = new Point(324, 49);
            bowBox.Name = "bowBox";
            bowBox.Size = new Size(30, 30);
            bowBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bowBox.TabIndex = 7;
            bowBox.TabStop = false;
            bowBox.Visible = false;
            // 
            // maceBox
            // 
            maceBox.BackColor = Color.Transparent;
            maceBox.BackgroundImageLayout = ImageLayout.Stretch;
            maceBox.Image = Properties.Resources.mace;
            maceBox.Location = new Point(360, 49);
            maceBox.Name = "maceBox";
            maceBox.Size = new Size(30, 30);
            maceBox.SizeMode = PictureBoxSizeMode.StretchImage;
            maceBox.TabIndex = 8;
            maceBox.TabStop = false;
            maceBox.Visible = false;
            // 
            // slot1
            // 
            slot1.BackColor = Color.Transparent;
            slot1.Image = Properties.Resources.sword;
            slot1.Location = new Point(72, 287);
            slot1.Name = "slot1";
            slot1.Size = new Size(50, 50);
            slot1.TabIndex = 9;
            slot1.TabStop = false;
            // 
            // slot2
            // 
            slot2.BackColor = Color.Transparent;
            slot2.Image = Properties.Resources.potion_red;
            slot2.Location = new Point(128, 287);
            slot2.Name = "slot2";
            slot2.Size = new Size(50, 50);
            slot2.TabIndex = 10;
            slot2.TabStop = false;
            // 
            // slot3
            // 
            slot3.BackColor = Color.Transparent;
            slot3.Image = Properties.Resources.mace;
            slot3.Location = new Point(184, 287);
            slot3.Name = "slot3";
            slot3.Size = new Size(50, 50);
            slot3.TabIndex = 11;
            slot3.TabStop = false;
            // 
            // slot4
            // 
            slot4.BackColor = Color.Transparent;
            slot4.Image = Properties.Resources.potion_blue;
            slot4.Location = new Point(240, 287);
            slot4.Name = "slot4";
            slot4.Size = new Size(50, 50);
            slot4.TabIndex = 12;
            slot4.TabStop = false;
            // 
            // slot5
            // 
            slot5.BackColor = Color.Transparent;
            slot5.Image = Properties.Resources.bow;
            slot5.Location = new Point(296, 287);
            slot5.Name = "slot5";
            slot5.Size = new Size(50, 50);
            slot5.TabIndex = 13;
            slot5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61F));
            tableLayoutPanel1.Controls.Add(ghoulHitPoints, 1, 3);
            tableLayoutPanel1.Controls.Add(ghostHitPoints, 1, 2);
            tableLayoutPanel1.Controls.Add(batHitPoints, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(playerHitPoints, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(360, 182);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(160, 72);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // ghoulHitPoints
            // 
            ghoulHitPoints.AutoSize = true;
            ghoulHitPoints.BackColor = Color.Transparent;
            ghoulHitPoints.Location = new Point(65, 54);
            ghoulHitPoints.Name = "ghoulHitPoints";
            ghoulHitPoints.Size = new Size(87, 15);
            ghoulHitPoints.TabIndex = 22;
            ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // ghostHitPoints
            // 
            ghostHitPoints.AutoSize = true;
            ghostHitPoints.BackColor = Color.Transparent;
            ghostHitPoints.Location = new Point(65, 36);
            ghostHitPoints.Name = "ghostHitPoints";
            ghostHitPoints.Size = new Size(86, 15);
            ghostHitPoints.TabIndex = 21;
            ghostHitPoints.Text = "ghostHitPoints";
            // 
            // batHitPoints
            // 
            batHitPoints.AutoSize = true;
            batHitPoints.BackColor = Color.Transparent;
            batHitPoints.Location = new Point(65, 18);
            batHitPoints.Name = "batHitPoints";
            batHitPoints.Size = new Size(73, 15);
            batHitPoints.TabIndex = 20;
            batHitPoints.Text = "batHitPoints";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 17;
            label3.Text = "Duch";
            // 
            // playerHitPoints
            // 
            playerHitPoints.AutoSize = true;
            playerHitPoints.BackColor = Color.Transparent;
            playerHitPoints.Location = new Point(65, 0);
            playerHitPoints.Name = "playerHitPoints";
            playerHitPoints.Size = new Size(88, 15);
            playerHitPoints.TabIndex = 19;
            playerHitPoints.Text = "playerHitPoints";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 23;
            label4.Text = "Upiór";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 15;
            label1.Text = "Gracz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 16;
            label2.Text = "Nietoperz";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(goUp, 1, 1);
            tableLayoutPanel2.Controls.Add(goDown, 1, 2);
            tableLayoutPanel2.Controls.Add(goLeft, 0, 2);
            tableLayoutPanel2.Controls.Add(goRight, 2, 2);
            tableLayoutPanel2.Location = new Point(360, 260);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(77, 77);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // goUp
            // 
            goUp.Location = new Point(28, 28);
            goUp.Name = "goUp";
            goUp.Size = new Size(19, 19);
            goUp.TabIndex = 1;
            goUp.Text = "↑";
            goUp.UseVisualStyleBackColor = true;
            goUp.Click += goUp_Click;
            // 
            // goDown
            // 
            goDown.Location = new Point(28, 53);
            goDown.Name = "goDown";
            goDown.Size = new Size(19, 19);
            goDown.TabIndex = 2;
            goDown.Text = "↓";
            goDown.UseVisualStyleBackColor = true;
            goDown.Click += goDown_Click;
            // 
            // goLeft
            // 
            goLeft.Location = new Point(3, 53);
            goLeft.Name = "goLeft";
            goLeft.Size = new Size(19, 20);
            goLeft.TabIndex = 0;
            goLeft.Text = "←";
            goLeft.UseVisualStyleBackColor = true;
            goLeft.Click += goLeft_Click;
            // 
            // goRight
            // 
            goRight.Location = new Point(53, 53);
            goRight.Name = "goRight";
            goRight.Size = new Size(19, 19);
            goRight.TabIndex = 3;
            goRight.Text = "→";
            goRight.UseVisualStyleBackColor = true;
            goRight.Click += goRight_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(324, 257);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 25;
            label10.Text = "Ruch";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(button5, 1, 1);
            tableLayoutPanel3.Controls.Add(button6, 0, 2);
            tableLayoutPanel3.Controls.Add(button7, 1, 2);
            tableLayoutPanel3.Controls.Add(button8, 2, 2);
            tableLayoutPanel3.Location = new Point(443, 260);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(77, 77);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // button5
            // 
            button5.Location = new Point(28, 28);
            button5.Name = "button5";
            button5.Size = new Size(19, 19);
            button5.TabIndex = 4;
            button5.Text = "↑";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 53);
            button6.Name = "button6";
            button6.Size = new Size(19, 19);
            button6.TabIndex = 5;
            button6.Text = "←";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(28, 53);
            button7.Name = "button7";
            button7.Size = new Size(19, 19);
            button7.TabIndex = 6;
            button7.Text = "↓";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(53, 53);
            button8.Name = "button8";
            button8.Size = new Size(19, 19);
            button8.TabIndex = 7;
            button8.Text = "→";
            button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(526, 257);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 24;
            label9.Text = "Atak";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.dungeon600x400;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 361);
            Controls.Add(playerBox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(slot5);
            Controls.Add(slot4);
            Controls.Add(slot3);
            Controls.Add(slot2);
            Controls.Add(slot1);
            Controls.Add(maceBox);
            Controls.Add(bowBox);
            Controls.Add(swordBox);
            Controls.Add(bluePotionBox);
            Controls.Add(redPotionBox);
            Controls.Add(ghoulBox);
            Controls.Add(ghostBox);
            Controls.Add(batBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Wyprawa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)batBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghostBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghoulBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)redPotionBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bluePotionBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)swordBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bowBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot4).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot5).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox playerBox;
        private PictureBox batBox;
        private PictureBox ghostBox;
        private PictureBox ghoulBox;
        private PictureBox redPotionBox;
        private PictureBox bluePotionBox;
        private PictureBox swordBox;
        private PictureBox bowBox;
        private PictureBox maceBox;
        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private PictureBox slot4;
        private PictureBox slot5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ghoulHitPoints;
        private Label label1;
        private Label ghostHitPoints;
        private Label label2;
        private Label batHitPoints;
        private Label label3;
        private Label playerHitPoints;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Button goUp;
        private Button goDown;
        private Button goLeft;
        private Button goRight;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}