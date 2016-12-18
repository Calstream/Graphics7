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
        bool draw = false;
        bool imExists = false;
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
            int w = pictureBox.Width;
            int h = pictureBox.Height;
            Bitmap im = new Bitmap(w,h);
            Graphics img = Graphics.FromImage(im);
            img.FillRectangle(Brushes.White, 0, 0, w, h);
            pictureBox.Image = im;
            imExists = true;
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

        private Color get_col()
        {
            Color res = Color.FromArgb(trackBarOP.Value,color_l.BackColor.R, color_l.BackColor.G, color_l.BackColor.B);
            return res;        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (imExists)
            {
                Color c = get_col();
                int thickness = trackBarTH.Value;
                draw = true;
                Image im = pictureBox.Image;
                Graphics g = Graphics.FromImage(im);
                Pen pen1 = new Pen(c, thickness);
                g.DrawEllipse(pen1, e.X, e.Y, 2, 2);
                g.Save();
                pictureBox.Image = im;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Image im = pictureBox.Image;
                Color c = get_col();
                int thickness = trackBarTH.Value;
                Graphics g = Graphics.FromImage(im);
                SolidBrush brush = new SolidBrush(c);
                g.FillEllipse(brush, e.X, e.Y, thickness, thickness);
                g.Save();
                pictureBox.Image = im;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }
    }
}
