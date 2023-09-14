using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Roczdział2cz2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            MyLabel.Text = "nazwa to " + name + "\nx jest równe " + x + "\nd jest równe " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;
            if (x == 10)
            {
                MyLabel.Text = "x musi być równe 10";
            }
            else
            {
                MyLabel.Text = "x nie jest równe 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Krzysiek";
            if ((someValue == 3) && (name.Equals("Janek")))
            {
                MyLabel.Text = "someValue jest równe 3 i name jest równe Janek";
            }
            MyLabel.Text = "ten wiersz jest wykonymany bez względu na warunki";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count += 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }

            MyLabel.Text = "Odpowiedź brzmi " + count;
        }
    }
}
