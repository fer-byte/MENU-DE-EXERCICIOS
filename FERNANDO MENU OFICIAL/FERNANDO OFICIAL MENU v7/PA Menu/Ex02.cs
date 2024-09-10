using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_Menu
{
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }
        private int cont = 0;
        private int cont2 = 0;
        private double resultado_serie = 0;
        private double resultato_paralelo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MENU form = new MENU();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            label13.Text = "";

            label11.Show();
            label2.Show();
            label10.Show();
            textBox4.Show();
            textBox5.Show();
            button4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Insira o valor da resistência";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Show();
            textBox2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt16(textBox1.Text);
            double vl_resistor = Convert.ToDouble(textBox2.Text);

            if (quantidade > cont)
            {
                resultado_serie += vl_resistor;
                textBox2.Clear();
                cont++;
            }
            else
            {
                MessageBox.Show("Acabaram os resistores !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (quantidade > cont2)
            {
                resultato_paralelo += 1 / vl_resistor;
                textBox2.Clear();
                cont2++;
            }

            double resultado_finalp = 1 / resultato_paralelo;
            label9.Text = resultado_finalp.ToString("N2");
            label8.Text = resultado_serie.ToString("N2");
            textBox2.Focus();


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label8.Text = "";
            label9.Text = "";
            label13.Text = "";

            cont = 0;
            cont2 = 0;

            resultado_serie = 0;
            resultato_paralelo = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label12.Show();
            label13.Show();

            double tensao = 0, corrente = 0, resultado_resistencia = 0;  //variáveis para descobrir a resistencia
            tensao = double.Parse(textBox4.Text);
            corrente = double.Parse(textBox5.Text);

            resultado_resistencia = tensao / corrente;

            label13.Text = $"{resultado_resistencia:F4}Ω";
        }

        private void Ex02_Load(object sender, EventArgs e)
        {

        }
    }
}