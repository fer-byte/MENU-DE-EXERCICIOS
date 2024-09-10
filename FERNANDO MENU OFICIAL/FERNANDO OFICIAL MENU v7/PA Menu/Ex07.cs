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
    public partial class Ex07 : Form
    {
        public Ex07()
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
            double peso = 0, altura = 0, imc = 0;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("PREENCHA OS DOIS CAMPOS PARA OBTER O RESULTADO", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                peso = double.Parse(textBox1.Text);
                altura = double.Parse(textBox2.Text);

                imc = peso / (altura * altura);

                label5.Text = $"{imc:F2}%";
                label4.Show();
                label5.Show();


                if (imc < 18.5)
                {


                    label6.Show();


                }

                else if (imc > 18.5 && imc < 25)
                {


                    label7.Show();

                }

                else if (imc > 24.9 && imc < 30)
                {



                    label8.Show();

                }

                else if (imc > 29.9 && imc < 35)
                {


                    label9.Show();

                }

                else if (imc > 34.5 && imc < 40)
                {


                    label11.Show();

                }

                else if (imc > 39.9)
                {

                    label10.Show();

                }

            }

        }

        private void Ex07_Load(object sender, EventArgs e)
        {

        }
    }
}
