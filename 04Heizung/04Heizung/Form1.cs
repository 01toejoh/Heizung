using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04Heizung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Heizen()
        {
            if (trb_Heizung1.Value<=15 || trb_Heizung2.Value <= 15 || trb_Heizung3.Value <= 15)
            {
                lbl_Farbe.ForeColor = Color.Red;
            }
            else if (trb_Heizung1.Value>=25 ||trb_Heizung2.Value>=25 || trb_Heizung3.Value>=25)
            {
                lbl_Farbe.ForeColor = Color.Black;
            }
            
        }

        private void trb_Heizung1_Scroll(object sender, EventArgs e)
        {
            Heizen();
            lbl_Value1.Text = Convert.ToString(trb_Heizung1.Value);
        }

        private void trb_Heizung2_Scroll(object sender, EventArgs e)
        {
            Heizen();
            lbl_Value2.Text = Convert.ToString(trb_Heizung2.Value);
        }

        private void trb_Heizung3_Scroll(object sender, EventArgs e)
        {
            Heizen();
            lbl_Value3.Text = Convert.ToString(trb_Heizung3.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hallo";
        }
    }
}
