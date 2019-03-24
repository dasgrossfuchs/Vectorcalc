using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double[] carga = new double[10];
        public double[] distancia = new double[10];
        public double fx = 0, fy = 0;
        public int current = 2;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            textBox13.Hide();
            textBox14.Hide();
            textBox15.Hide();
            textBox16.Hide();
            textBox17.Hide();
            textBox18.Hide();
            textBox19.Hide();
            textBox20.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current--;
            if (current < 10) { button3.Show(); }
            if (current == 2) { button2.Hide(); }
            switch (current)
            {
                case 2: label3.Hide(); textBox3.Hide(); textBox13.Hide(); break;
                case 3: label4.Hide(); textBox4.Hide(); textBox14.Hide(); break;
                case 4: label5.Hide(); textBox5.Hide(); textBox15.Hide(); break;
                case 5: label6.Hide(); textBox6.Hide(); textBox16.Hide(); break;
                case 6: label7.Hide(); textBox7.Hide(); textBox17.Hide(); break;
                case 7: label8.Hide(); textBox8.Hide(); textBox18.Hide(); break;
                case 8: label9.Hide(); textBox9.Hide(); textBox19.Hide(); break;
                case 9: label10.Hide(); textBox10.Hide(); textBox20.Hide(); break;


                default:
                    break;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            current++;
            if (current == 10) { button3.Hide(); }
            if (current > 2) { button2.Show(); }
            switch (current)
            {
                case 3: label3.Show(); textBox3.Show(); textBox13.Show(); break;
                case 4: label4.Show(); textBox4.Show(); textBox14.Show(); break;
                case 5: label5.Show(); textBox5.Show(); textBox15.Show(); break;
                case 6: label6.Show(); textBox6.Show(); textBox16.Show(); break;
                case 7: label7.Show(); textBox7.Show(); textBox17.Show(); break;
                case 8: label8.Show(); textBox8.Show(); textBox18.Show(); break;
                case 9: label9.Show(); textBox9.Show(); textBox19.Show(); break;
                case 10: label10.Show(); textBox10.Show(); textBox20.Show(); break;

                default:
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }


        //seccion que hace que no puedas escribir letras o mas de un numero


        private void button1_Click(object sender, EventArgs e)
        {

            int to = 0;
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (radioButton1.Checked)
                { to = -9; }
                if (radioButton2.Checked)
                { to = -6; }
                if (radioButton3.Checked)
                { to = -3; }
            }
            

            double k = 9*Math.Pow(10, 9);
            double prefix = Math.Pow(10,to);
            if (true == true)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox11.Text))
                { textBox1.Text = "0"; textBox11.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
                { textBox2.Text = "0"; textBox12.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox13.Text))
                { textBox3.Text = "0"; textBox13.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox14.Text))
                { textBox4.Text = "0"; textBox14.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox15.Text))
                { textBox5.Text = "0"; textBox15.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox16.Text))
                { textBox6.Text = "0"; textBox16.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox17.Text))
                { textBox7.Text = "0"; textBox17.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox18.Text))
                { textBox8.Text = "0"; textBox18.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
                { textBox9.Text = "0"; textBox19.Text = "0"; }
                if (string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
                { textBox10.Text = "0"; textBox20.Text = "0"; }
            }//campos default
            if (true == true)
            {

                carga[0] = double.Parse((textBox1.Text));
                distancia[0] = double.Parse((textBox11.Text).ToString());

                carga[1] = double.Parse((textBox2.Text).ToString());
                distancia[1] = double.Parse((textBox12.Text).ToString());

                carga[2] = double.Parse((textBox3.Text).ToString());
                distancia[2] = double.Parse((textBox13.Text).ToString());

                carga[3] = double.Parse((textBox4.Text).ToString());
                distancia[3] = double.Parse((textBox14.Text).ToString());

                carga[4] = double.Parse((textBox5.Text).ToString());
                distancia[4] = double.Parse((textBox15.Text).ToString());

                carga[5] = double.Parse((textBox6.Text).ToString());
                distancia[5] = double.Parse((textBox16.Text).ToString());

                carga[6] = double.Parse((textBox7.Text).ToString());
                distancia[6] = double.Parse((textBox17.Text).ToString());

                carga[7] = double.Parse((textBox8.Text).ToString());
                distancia[7] = double.Parse((textBox18.Text).ToString());

                carga[8] = double.Parse((textBox9.Text).ToString());
                distancia[8] = double.Parse((textBox19.Text).ToString());

                carga[9] = double.Parse((textBox10.Text).ToString());
                distancia[9] = double.Parse((textBox20.Text).ToString());

            }//captura campos
            double v = 0;
            for (int i = 0; i < 10; i++)
            {
                if (distancia[i] > 0)
                {
                    v = v + k * carga[i]*prefix/ distancia[i];
                }
                    
            }//suma los voltajes
            v = Math.Round(v,3);
            string resultado = v.ToString();
            label14.Text = resultado+" v";
            
            
            



        }
    }
}
