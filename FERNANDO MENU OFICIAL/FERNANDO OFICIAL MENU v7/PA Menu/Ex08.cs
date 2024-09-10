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
    public partial class Ex08 : Form
    {
        public Ex08()
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

        private void Ex08_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor_prod = 0, valor_final = 0, valor_parcela = 0, desconto = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("INSIRA O VALOR DO PRODUTO!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                valor_prod = double.Parse(textBox1.Text);

                valor_final = valor_prod * 0.85;

                desconto = valor_prod * 0.15;

                label4.Text = "COMPRA À VISTA DESCONTO DE 15%";

                label5.Text = $"DESCONTO R${desconto:F2}";

                label6.Text = $"VALOR FINAL DO PRODUTO R${valor_final:F2}";

                button7.Show();

            }
        }

            

        private void button3_Click(object sender, EventArgs e)
        {
            double valor_prod = 0, valor_final = 0, valor_parcela = 0, desconto = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("INSIRA O VALOR DO PRODUTO!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                valor_prod = double.Parse(textBox1.Text);

                valor_final = valor_prod * 0.90;

                desconto = valor_prod * 0.1;

                label4.Text = "COMPRA À VISTA DESCONTO DE 10%";

                label5.Text = $"DESCONTO R${desconto:F2}";

                label6.Text = $"VALOR FINAL DO PRODUTO  R${valor_final:F2}";

                button7.Show();
            }
        }

            

        private void button4_Click(object sender, EventArgs e)
        {
            double valor_prod = 0, valor_final = 0, valor_parcela = 0, juros = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("INSIRA O VALOR DO PRODUTO!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                valor_prod = double.Parse(textBox1.Text);

                valor_final = valor_prod;

                valor_parcela = valor_prod / 2;

                label4.Text = $"SEM ALTERAÇÃO NO VALOR!";

                label5.Text = $"2 PARCELAS DE R${valor_parcela:F2}";

                label6.Text = $"VALOR FINAL DO PRODUTO R${valor_final:F2}";

                button7.Show();
            }
        }

           

        private void button5_Click(object sender, EventArgs e)
        {
            double valor_prod = 0, valor_final = 0, valor_parcela = 0, juros = 0, quantidade_parcelas = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("INSIRA O VALOR DO PRODUTO!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                textBox2.Show();
                label7.Show();
                button6.Show();

                valor_prod = double.Parse(textBox1.Text);

                valor_final = (valor_prod * 1.1);

                valor_parcela = valor_prod / quantidade_parcelas;

                juros = valor_prod * 0.1;

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valor_prod = 0, valor_final = 0, valor_parcela = 0, juros = 0, quantidade_parcelas = 0;

            if(textBox2.Text == "")
            {
                MessageBox.Show("INSIRA A QUANTIDADE DE PARCELAS POR FAVOR!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                textBox2.Show();
                label7.Show();



                valor_prod = double.Parse(textBox1.Text);
                quantidade_parcelas = double.Parse(textBox2.Text);

                if (quantidade_parcelas < 3)
                {
                    MessageBox.Show("INSIRA 3 OU MAIS PARCELAS ", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    valor_final = (valor_prod * 1.1);

                    valor_parcela = valor_final / quantidade_parcelas;

                    juros = valor_prod * 0.1;

                    label4.Text = $"JUROS DE 10%";

                    label5.Text = $"{quantidade_parcelas} PARCELAS DE R$ {valor_parcela:F2}";

                    label6.Text = $"VALOR FINAL DO PRODUTO R${valor_final:F2}";

                    button7.Show();
                }

            }
        }

            

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMPRA FINALIZADA COM SUCESSO", "OBRIGADO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            textBox1.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Hide();
            textBox2.Hide();
            button6.Hide();
            textBox2.Text = "";
        }
    }
}
