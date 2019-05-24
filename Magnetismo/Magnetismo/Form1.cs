using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magnetismo
{
    public partial class Form1 : Form
    {
        public int selection = 1;
        Point rt = new Point(250, 50);
        Point rl = new Point(250, 35);
        Point para11 = new Point(50, 35);
        Point para12 = new Point(50, 50);
        Point para21 = new Point(50, 100);
        Point para22 = new Point(50, 115);
        Point para31 = new Point(50, 165);
        Point para32 = new Point(50, 180);
        double fuerza,campo,corriente,longitud;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tb1.Text))
            { tb1.Text = "0"; }
            if (string.IsNullOrWhiteSpace(tb2.Text))
            { tb2.Text = "0"; }
            if (string.IsNullOrWhiteSpace(tb3.Text))
            { tb3.Text = "0"; }
            if (string.IsNullOrWhiteSpace(tb4.Text))
            { tb4.Text = "0"; }
            fuerza = double.Parse(tb1.Text);
            campo = double.Parse(tb2.Text);
            longitud = double.Parse(tb3.Text);
            corriente = double.Parse(tb4.Text);
            switch (selection)
            {
                case 1:
                    fuerza = campo * longitud * corriente;
                    tb1.Text = fuerza.ToString();
                    break;
                case 2:
                    campo = fuerza/(longitud * corriente);
                    tb2.Text = campo.ToString();
                    break;
                case 3:
                    longitud = fuerza/(campo*corriente);
                    tb3.Text = longitud.ToString();
                    break;
                case 4:
                    corriente = fuerza/(longitud*campo);
                    tb4.Text = corriente.ToString();
                    break;
                default:
                    break; 
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { selection = 1;
                label1.Location = rl;
                tb1.Location = rt;

                label2.Location = para11;
                tb2.Location = para12;
                label3.Location = para21;
                tb3.Location = para22;
                label4.Location = para31;
                tb4.Location = para32;
            }
            if (radioButton2.Checked) { selection = 2;
                label2.Location = rl;
                tb2.Location = rt;

                label1.Location = para11;
                tb1.Location = para12;
                label3.Location = para21;
                tb3.Location = para22;
                label4.Location = para31;
                tb4.Location = para32;
            }
            if (radioButton3.Checked) { selection = 3;
                label3.Location = rl;
                tb3.Location = rt;

                label1.Location = para11;
                tb1.Location = para12;
                label2.Location = para21;
                tb2.Location = para22;
                label4.Location = para31;
                tb4.Location = para32;
            }
            if (radioButton4.Checked) { selection = 4;
                label4.Location = rl;
                tb4.Location = rt;

                label1.Location = para11;
                tb1.Location = para12;
                label2.Location = para21;
                tb2.Location = para22;
                label3.Location = para31;
                tb3.Location = para32;
            }
            
        }
        
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            

            }
    }
}
