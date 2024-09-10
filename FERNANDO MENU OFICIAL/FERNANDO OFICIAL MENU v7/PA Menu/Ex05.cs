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
    public partial class Ex05 : Form
    {
        public Ex05()
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

        private void Ex05_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dist_perc = 0, consumo_etanol = 0, consumo_gasolina = 0, consumo_diesel = 0, preco_etanol = 0, preco_gasolina = 0,
                   preco_diesel = 0, tamanho_tanque = 0;

            double val_total_etanol = 0, val_total_gasolina = 0, val_total_diesel = 0,
                   consumo_rs_l_etanol = 0, consumo_rs_l_gasolina = 0, consumo_rs_l_diesel = 0,
                   qtd_tanques_etanol = 0, qtd_tanques_gasolina = 0, qtd_tanques_diesel = 0;


            if(textBox1.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("CAMPOS (DISTÂNCIA PERCORRIDA) (TAMANHO DO TANQUE) OBRIGATÓRIOS!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else
                {
                    // FUNCIONALIDADE PARA CONVERTER TEXTBOX VAZIAS EM NUMERAL "0"      |||||| ETANOL ||||||
                    if (textBox4.Text == "" || textBox2.Text == "")
                    {
                        textBox4.Text = "0";
                        textBox2.Text = "0";

                    }

                    // FUNCIONALIDADE PARA CONVERTER TEXTBOX VAZIAS EM NUMERAL "0"      |||||| GASOLINA ||||||
                    if (textBox3.Text == "" || textBox7.Text == "")
                    {
                        textBox3.Text = "0";
                        textBox7.Text = "0";
                    }

                    // FUNCIONALIDADE PARA CONVERTER TEXTBOX VAZIAS EM NUMERAL "0"      |||||| DIESEL ||||||
                    if (textBox5.Text == "" || textBox6.Text == "")
                    {
                        textBox5.Text = "0";
                        textBox6.Text = "0";
                    }


                    dist_perc = double.Parse(textBox1.Text);

                    preco_etanol = double.Parse(textBox4.Text);
                    preco_gasolina = double.Parse(textBox3.Text);
                    preco_diesel = double.Parse(textBox5.Text);

                    consumo_etanol = double.Parse(textBox2.Text);
                    consumo_gasolina = double.Parse(textBox7.Text);
                    consumo_diesel = double.Parse(textBox6.Text);

                    tamanho_tanque = double.Parse(textBox8.Text);



                    // FUNCIONALIDADE PARA CONVERTER TEXTBOX DE NUMERAL "0" PARA "------------"      |||||| ETANOL ||||||
                    if (textBox4.Text == "0" || textBox2.Text == "0")
                    {
                        label21.Text = "------------";
                        label26.Text = "------------";
                        label29.Text = "------------";
                    }
                    else                    // DECLARAÇÃO DE PRINTS DENTRO DA TABELA //
                    {
                        //  Val. Total Gasto                   |||||| ETANOL ||||||
                        val_total_etanol = (dist_perc / consumo_etanol) * preco_etanol;
                        label21.Text = $"R${val_total_etanol:F2}";

                        //  Consumo RS/L                       |||||| ETANOL ||||||
                        consumo_rs_l_etanol = ((dist_perc / consumo_etanol) * preco_etanol) / preco_etanol;
                        label26.Text = $"R${consumo_rs_l_etanol:F2}/L";

                        //  QTD. Tanques de combustível        |||||| ETANOL ||||||
                        qtd_tanques_etanol = ((dist_perc / consumo_etanol) * preco_etanol) / (tamanho_tanque * preco_etanol);
                        label29.Text = $"{qtd_tanques_etanol:F2}%";
                    }


                    // FUNCIONALIDADE PARA CONVERTER TEXTBOX DE NUMERAL "0" PARA "------------"      |||||| GASOLINA ||||||
                    if (textBox3.Text == "0" || textBox7.Text == "0")
                    {
                        label22.Text = "------------";
                        label25.Text = "------------";
                        label28.Text = "------------";
                    }
                    else
                    {
                        //  Val. Total Gasto    |||||| GASOLINA ||||||
                        val_total_gasolina = (dist_perc / consumo_gasolina) * preco_gasolina;
                        label22.Text = $"R${val_total_gasolina:F2}";

                        //  Consumo RS/L                       |||||| GASOLINA ||||||
                        consumo_rs_l_gasolina = ((dist_perc / consumo_gasolina) * preco_gasolina) / preco_gasolina;
                        label25.Text = $"R${consumo_rs_l_gasolina:F2}/L";

                        //  QTD. Tanques de combustível        |||||| GASOLINA ||||||
                        qtd_tanques_gasolina = ((dist_perc / consumo_gasolina) * preco_gasolina) / (tamanho_tanque * preco_gasolina);
                        label28.Text = $"{qtd_tanques_gasolina:F2}%";
                    }


                    // FUNCIONALIDADE PARA CONVERTER TEXTBOX DE NUMERAL "0" PARA "------------"      |||||| DIESEL ||||||
                    if (textBox5.Text == "0" || textBox6.Text == "0")
                    {
                        label23.Text = "------------";
                        label24.Text = "------------";
                        label27.Text = "------------";
                    }
                    else
                    {
                        //  Val. Total Gasto    |||||| DIESEL ||||||
                        val_total_diesel = (dist_perc / consumo_diesel) * preco_diesel;
                        label23.Text = $"R${val_total_diesel:F2}";

                        //  Consumo RS/L                       |||||| DIESEL ||||||
                        consumo_rs_l_diesel = ((dist_perc / consumo_diesel) * preco_diesel) / preco_diesel;
                        label24.Text = $"R${consumo_rs_l_diesel:F2}/L";

                        //  QTD. Tanques de combustível        |||||| DIESEL ||||||
                        qtd_tanques_diesel = ((dist_perc / consumo_diesel) * preco_diesel) / (tamanho_tanque * preco_diesel);
                        label27.Text = $"{qtd_tanques_diesel:F2}%";
                    }


                }
            
        }


               



        private void button3_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            label28.Text = "";
            label27.Text = "";

            label24.Text = "";
            label25.Text = "";
            label26.Text = "";

            label23.Text = "";
            label22.Text = "";
            label21.Text = "";

            textBox4.Text = "";
            textBox1.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";

        }
    }
}
