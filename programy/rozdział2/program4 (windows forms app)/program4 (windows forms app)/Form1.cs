using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program4__windows_forms_app_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enableCheckbox.Checked == true)
            {
                if (labelToChange.Text == "Z prawej")
                {
                    labelToChange.Text = "Z lewej";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelToChange.Text = "Z prawej";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                labelToChange.Text = "Możliwość zmiany tekstu została wyłączona";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
