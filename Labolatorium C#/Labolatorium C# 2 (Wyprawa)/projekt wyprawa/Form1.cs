using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_wyprawa
{
    public partial class Form1 : Form
    {

        private Game game;
        private Random random = new Random();
        public Form1()
        {

            InitializeComponent();

        }

        public void UpdateCharacters()
        {
            playerPicture.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batPicture.Visible = true;
                    batPicture.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostPicture.Visible = true;
                    ghostPicture.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoulPicture.Visible = true;
                    ghoulPicture.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (!showBat)
            {
                batPicture.Visible = false;
                batHitPoints.Text = "";
            }
            if (!showGhost)
            {
                ghostPicture.Visible = false;
                ghostHitPoints.Text = "";
            }
            if (!showGhoul)
            {
                ghoulPicture.Visible = false;
                ghoulHitPoints.Text = "";
            }
            swordPicture.Visible = false;
            bowPicture.Visible = false;
            redPicture.Visible = false;
            bluePicture.Visible = false;
            macePicture.Visible = false;
            PictureBox weaponControl = null;


            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = swordPicture; break;
                case "Luk":
                    weaponControl = bowPicture; break;
                case "Bulawa":
                    weaponControl = macePicture; break;
                case "Czerwona mikstura":
                    weaponControl = redPicture; break;
                case "Niebieska mikstura":
                    weaponControl = bluePicture; break;
            }
            if (weaponControl != null)
            {
                weaponControl.Visible = true;
                weaponControl.Location = game.WeaponInRoom.Location;
                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
                {
                    weaponControl.Visible = true;
                }
            }

            PictureBox weaponInventoryShow = null;
            foreach (string weapon in game.PlayerWeapons)
            {

                if (game.CheckPlayerInventory(weapon))
                {

                    switch (weapon)
                    {
                        case "Miecz":
                            weaponInventoryShow = swordBox; break;
                        case "Luk":
                            weaponInventoryShow = bowBox; break;
                        case "Bulawa":
                            weaponInventoryShow = maceBox; break;
                        case "Czerwona mikstura":
                            weaponInventoryShow = redBox; break;
                        case "Niebieska mikstura":
                            weaponInventoryShow = blueBox; break;
                    }
                    weaponInventoryShow.Visible = true;
                    if (game.WasPotionUsed(weapon))
                        weaponInventoryShow.Visible = false;
                    if (game.PlayerWeapons.Count() == 1)
                        weaponInventoryShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("zostales zabity", "koniec gry");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("pokonales przeciwnikow na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }

        }

        private void swordBox_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Miecz"))
            {
                game.Equip("Miecz");
                swordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                bowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                maceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                blueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                redBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Text = "↑";

            }
            else return;
        }

        private void bowBox_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Luk"))
            {
                game.Equip("Luk");
                swordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                bowBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                maceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                blueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                redBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Text = "↑";

            }
            else return;
        }

        private void maceBox_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bulawa"))
            {
                game.Equip("Bulawa");
                swordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                bowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                maceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                blueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                redBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Text = "↑";
            }
            else return;
        }

        private void blueBox_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Niebieska mikstura"))
            {
                game.Equip("Niebieska mikstura");
                swordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                bowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                maceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                blueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                redBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Text = "wypij";
            }
            else return;
        }

        private void redBox_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Czerwona mikstura"))
            {
                game.Equip("Czerwona mikstura");
                swordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                bowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                maceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                blueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                redBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Text = "wypij";
            }
            else return;
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

    }


}



