using System.Diagnostics;

namespace Program_5__Typy_kodowania_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes) Debug.WriteLine("{0} ", b);
            Debug.WriteLine("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes) Debug.WriteLine("{0:x2} ", b);
            Debug.WriteLine("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "パソコン学");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes) Debug.WriteLine("{0:x2} ", b);
            Debug.WriteLine("");
        }
    }
}