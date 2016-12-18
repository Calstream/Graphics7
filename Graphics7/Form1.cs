using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;
            int value = tb.Value;
            string labelname = tb.Name + "val";
            Label val = Controls["panel1"].Controls[labelname] as Label;
            val.Text = value.ToString();
        }

        private void newMenu_Click(object sender, EventArgs e)
        {

        }

        private void openMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveMenu_Click(object sender, EventArgs e)
        {

        }

        private void exitMenu_Click(object sender, EventArgs e)
        {

        }

        private void color_l_Click(object sender, EventArgs e)
        { 
            Label l = sender as Label;
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                l.BackColor = colorDialog1.Color;
            }
        }
    }
}
