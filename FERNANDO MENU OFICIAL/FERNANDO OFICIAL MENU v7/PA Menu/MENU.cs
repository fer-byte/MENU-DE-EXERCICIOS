using PA_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            Ex01 form = new Ex01();
            form.Closed += (s, args) => this.Close();

            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex02 form = new Ex02();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex03 form = new Ex03();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex04 form = new Ex04();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex05 form = new Ex05();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex06 form = new Ex06();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex07 form = new Ex07();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Ex08 form = new Ex08();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex01 form = new Ex01();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex02 form = new Ex02();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex03 form = new Ex03();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex04 form = new Ex04();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex05 form = new Ex05();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex06 form = new Ex06();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex07 form = new Ex07();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ex08 form = new Ex08();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
