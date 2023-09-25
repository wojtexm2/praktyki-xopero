using System.Runtime.Serialization.Formatters.Binary;

namespace Program2___projekt_dla_facetów__
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 50, Name = "Bob" };
            UpdateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.RecieveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.RecieveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.RecieveCash(bob.GiveCash(10));
            UpdateForm();
        }

        private void saveJoe_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Plik_faceta.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void loadJoe_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Plik_faceta.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}