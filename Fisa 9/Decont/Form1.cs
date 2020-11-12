using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml.Serialization;
using ExchangeRate_API;

namespace Decont
{
    public partial class Form1 : Form
    {
        public double rataDeConversie;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumarCorect(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                if (e.KeyChar != 46)
                    if (e.KeyChar != 8)
                        e.KeyChar = '\0';
        }

        private void Init()
        {
            rataDeConversie = Rates.Import();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = rataDeConversie.ToString();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal pret, consum, km, total;
            pret = decimal.Parse(textBox1.Text);
            consum = decimal.Parse(textBox2.Text);
            km = decimal.Parse(textBox3.Text);
            total = ((km * consum) / 100) * pret;

            if (radioButton2.Checked)
                total = 2 * total;

            decimal tb5Content = Math.Truncate(total * 100) / 100, tb6Content = Math.Truncate((total * 100 * decimal.Parse(textBox5.Text))) / 100;
            textBox4.Text = String.Format($"{0:0.00}", tb5Content);
            textBox6.Text = String.Format($"{0:0.00}", tb6Content);
            button2.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { 
                textBox2.Focus(); 
            }
            else
                NumarCorect(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox3.Focus();
                e.Handled = true;
            }
            else
                NumarCorect(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { 
                button1.Focus();
                e.Handled = true;
            }
            else
                NumarCorect(e);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
