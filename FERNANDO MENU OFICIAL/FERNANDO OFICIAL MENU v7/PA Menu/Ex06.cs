using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_Menu
{
    public partial class Ex06 : Form
    {
        public Ex06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU form = new MENU();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double celsius = 0, fah = 0, resultado = 0, valor_digitado = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira um valor de temperatura!!!", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                valor_digitado = double.Parse(textBox1.Text);

                resultado = valor_digitado * 1.8 + 32;

                label6.Show();
                label5.Text = $"{valor_digitado:F2}°C";
                label4.Text = $"{resultado:F2}°F";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double celsius = 0, fah = 0, resultado = 0, valor_digitado=0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira um valor de temperatura!!!", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                valor_digitado = double.Parse(textBox1.Text);

                resultado = (valor_digitado - 32) / 1.8;

                label6.Show();
                label5.Text = $"{valor_digitado:F2}°F";
                label4.Text = $"{resultado:F2}°C";
            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double celsius = 0, kelvin = 0, resultado = 0, valor_digitado = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira um valor de temperatura!!!", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                valor_digitado = double.Parse(textBox1.Text);

                resultado = valor_digitado + 273.15;

                label6.Show();
                label5.Text = $"{valor_digitado:F2}°C";
                label4.Text = $"{resultado:F2}°K";
            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double celsius = 0, kelvin = 0, resultado = 0, valor_digitado = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira um valor de temperatura!!!", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                valor_digitado = double.Parse(textBox1.Text);

                resultado = valor_digitado - 273.15;

                label6.Show();
                label5.Text = $"{valor_digitado:F2}°K";
                label4.Text = $"{resultado:F2}°C";
            }

            

        }

        private void Ex06_Load(object sender, EventArgs e)
        {

        }
    }
}
