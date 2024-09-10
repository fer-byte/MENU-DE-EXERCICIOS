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
    public partial class Ex04 : Form
    {
        public Ex04()
        {
            InitializeComponent();
        }

        private int cont = 0;
        private int cont2 = 0;
        private double media = 0;
        private double total_notas = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MENU form = new MENU();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Ex04_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt16(textBox1.Text);
            double vl_nota = Convert.ToDouble(textBox2.Text);


            if (quantidade > cont)
            {
                total_notas += vl_nota;
                textBox2.Clear();
                cont++;
            }
            else
            {
                MessageBox.Show("Já foram preenchidas todas as notas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            label8.Text = $"{total_notas / quantidade:F2}";
            textBox2.Focus();

            media = total_notas / quantidade;

            if (media >= 7)
            {
                label2.Show();
                label7.Hide();
            }
            else
            {
                label7.Show();
                label2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label8.Text = "";
            label2.Hide();
            label7.Hide();

            total_notas = 0;
            cont = 0;
            media = 0;

        }
    }
}