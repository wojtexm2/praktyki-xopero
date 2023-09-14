using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program6__coś_błyskotliwego_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            while (Visible)
            {
                for (int c = 0; c <= 255; c++)
                {
                    Application.DoEvents();
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    System.Threading.Thread.Sleep(3);
                }
                for (int c = 255; c >= 0; c--)
                {
                    Application.DoEvents();
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    System.Threading.Thread.Sleep(3);
                }
            }
            
        }
    }
}
