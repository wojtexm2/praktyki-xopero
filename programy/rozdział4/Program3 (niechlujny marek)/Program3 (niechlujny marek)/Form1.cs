namespace Program3__niechlujny_marek_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
            label1.Text = menu.getMenuItem();
            label2.Text = menu.getMenuItem();
            label3.Text = menu.getMenuItem();
            label4.Text = menu.getMenuItem();
            label5.Text = menu.getMenuItem();
            label6.Text = menu.getMenuItem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}