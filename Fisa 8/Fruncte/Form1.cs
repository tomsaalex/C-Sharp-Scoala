using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruncte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (măr.Checked && (!morcov.Checked) &&
            pară.Checked && strugure.Checked && (!varză.Checked))
                    MessageBox.Show("CORECT");
                else
                    MessageBox.Show("GRESIT. Mai incearca! ");
                radioButton1.Checked = false;
                groupBox1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Mai gândiţi - vă şi încercaţi din nou");
                groupBox1.Visible = false;
                radioButton2.Checked = false;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
            button1.Text = "Ai ales raspunsul";
            button1.ForeColor = Color.Magenta;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.Text = "Verifica";
            button1.ForeColor = Color.Black;
        }
    }
}
