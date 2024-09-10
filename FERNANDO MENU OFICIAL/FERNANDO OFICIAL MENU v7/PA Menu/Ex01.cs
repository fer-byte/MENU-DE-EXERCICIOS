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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PA_Menu
{
    public partial class Ex01 : Form
    {
        public Ex01()
        {
            InitializeComponent();
        }

        private void Ex01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU form = new MENU();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double res_1 = 0, res_2 = 0, res_3 = 0;                     
            double resistencia_serie = 0, resistencia_paralelo = 0;      

   
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("PREENCHA TODOS OS VALORES DE RESISTÊNCIAS", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                res_1 = double.Parse(textBox1.Text);

                res_2 = double.Parse(textBox2.Text);

                res_3 = double.Parse(textBox3.Text);


                if (res_1 < 0)
                {
                    res_1 = res_1 * (-1);
                }

                else if (res_2 < 0)
                {
                    res_2 = res_2 * (-1);
                }

                else if (res_3 < 0)
                {
                    res_3 = res_3 * (-1);
                }


                resistencia_paralelo = 1 / (1 / res_1 + 1 / res_2 + 1 / res_3);
                resistencia_serie = res_1 + res_2 + res_3;

                label8.Text = $"{resistencia_serie:F4}Ω";
                label9.Text = $"{resistencia_paralelo:F4}Ω";
            }
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label8.Text = "";
            label9.Text = "";
            label13.Text = "";

            //label8.Hide();
            //label9.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
