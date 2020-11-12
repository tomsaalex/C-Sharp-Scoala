using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culori
{
    public partial class FormaMea : Form
    {
        public FormaMea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); // se deschide dialogul ColorDialog care
                                       // va afişa paleta de culori din cae vom alege
            this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
            label1.Text = label1.Text.ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* if (textBox1.Text == "")
                 MessageBox.Show("Scrieti noul titlu in caseta text!");
             else
                 label1.Text = textBox1.Text;
         */
            var rezultat = MessageBox.Show("Modificati titlul?", "Atentie !", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
                label1.Text = textBox1.Text;
        }

        private void FormaMea_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button3.Visible = true;
            else
                button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar <= 57)
                MessageBox.Show("Ati ales o cifra. ");
            if (e.KeyChar == 13)
                MessageBox.Show("Ati apasat Enter.");
            int nr = e.KeyChar;
            textBox3.Text = nr.ToString(); //afisam codul caracterului introdus
        }

    }
}
