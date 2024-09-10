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
    public partial class Ex03 : Form
    {
        public Ex03()
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

        private void Ex03_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double nota_1 = 0, nota_2 = 0, nota_3 =0, nota_4 = 0;
            double media = 0;


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "")
            {
                    MessageBox.Show("PREENCHA TODAS AS NOTAS", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                nota_1 = double.Parse(textBox1.Text);
                nota_2 = double.Parse(textBox2.Text);
                nota_3 = double.Parse(textBox3.Text);
                nota_4 = double.Parse(textBox6.Text);

                media = (nota_1 + nota_2 + nota_3 + nota_4) / 4;

                label8.Text = $"{media:F2}";

                if (media >= 70)
                {
                    label2.Show();
                }
                else
                {
                    label7.Show();
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //12368
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            label8.Text = "";

            label2.Hide();
            label7.Hide();

        }
    }
}
