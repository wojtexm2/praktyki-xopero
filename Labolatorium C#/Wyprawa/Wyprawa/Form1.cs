namespace Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
        public void UpdateCharacters()
        {
            playerBox.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batBox.Visible = true;
                    batBox.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostBox.Visible = true;
                    ghostBox.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoulBox.Visible = true;
                    ghoulBox.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat == false)
            {
                batBox.Visible = false;
                batHitPoints.Text = "";
            }
            if (showGhost == false)
            {
                ghostBox.Visible = false;
                ghostHitPoints.Text = "";
            }
            if (showGhoul == false)
            {
                ghoulBox.Visible = false;
                ghoulHitPoints.Text = "";
            }
            swordBox.Visible = false;
            bowBox.Visible = false;
            redPotionBox.Visible = false;
            bluePotionBox.Visible = false;
            maceBox.Visible = false;
            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = swordBox;
                    break;
                case "Luk":
                    weaponControl = bowBox;
                    break;
                case "Bulawa":
                    weaponControl = maceBox;
                    break;
                case "Niebieska mikstura":
                    weaponControl = bluePotionBox;
                    break;
                case "Czerwona mikstura":
                    weaponControl = redPotionBox;
                    break;
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

        private void goLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void goUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void goDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void goRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }
    }
}