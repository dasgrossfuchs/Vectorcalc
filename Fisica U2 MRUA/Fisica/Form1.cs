using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile(@"pngpng.png");
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.Size = new Size(200,200);
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(altura.Text))
            { altura.Text = "0";}
            if (string.IsNullOrWhiteSpace(velocidad.Text))
            { velocidad.Text = "0";}
            double v = double.Parse((velocidad.Text).ToString());
            double h = double.Parse((altura.Text).ToString());

            double t = Math.Round(Math.Sqrt(h*2/9.81),3);
            double x = Math.Round(t*v, 3);

            ylabel.Text = altura.Text+" m";
            xlabel.Text = x.ToString()+" m";
            totalx.Text = x.ToString()+"Metros";
            tiempo.Text = t.ToString()+"Segundos";


        }

        private void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void velocidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
