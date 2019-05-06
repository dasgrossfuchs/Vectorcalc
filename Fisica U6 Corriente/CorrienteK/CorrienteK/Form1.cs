using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrienteK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i1.Text = "total";
            i2.Text = "total";
            Image image = Image.FromFile(@"circuit.png");
            pictureBox1.Size = new Size(image.Width, image.Height);
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(v1.Text))
            { v1.Text = "0"; }
            if (string.IsNullOrWhiteSpace(v2.Text))
            { v2.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r1.Text))
            { r1.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r2.Text))
            { r2.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r3.Text))
            { r3.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r4.Text))
            { r4.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r5.Text))
            { r5.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r6.Text))
            { r6.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r7.Text))
            { r7.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r8.Text))
            { r8.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r9.Text))
            { r9.Text = "0"; }
            if (string.IsNullOrWhiteSpace(r10.Text))
            { r10.Text = "0"; }
            string[] rt = {r1.Text, r2.Text, r3.Text, r4.Text, r5.Text, r6.Text, r7.Text, r8.Text, r9.Text,r10.Text };
            int[] ri = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ri[i] = int.Parse(rt[i]);
            }
            int b1 = int.Parse(v1.Text), b2 = int.Parse(v2.Text);
            int a = ri[0] + ri[1] + ri[2] + ri[3] + ri[4] + ri[5];
            int c = ri[2] + ri[3] + ri[6] + ri[7] + ri[8] + ri[9];
            int b = ri[2] + ri[3];
            
            double dif = (a*c)-(b*b);
            double dif1 = (b1 * c) - (b2 * b);
            double dif2 = (a * b2) - (b * b1);
            if (dif==0)
            {
                dif = 1;
            }
            i1.Text=Math.Round(dif1 / dif,5).ToString()+"A";
            i2.Text = Math.Round(dif2 / dif, 5).ToString()+"A";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
