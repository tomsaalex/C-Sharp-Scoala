using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaAplicatie
{
    public partial class Calculatorinatorul : Form
    {
        public Calculatorinatorul()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = 0, b = 0;
            try
            {
                a = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primul număr este incorect");
                a = 0;
                b = 0;
                textBox1.Text = "";
            }

            try
            {
                b = float.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Al doilea număr este incorect");
                a = 0;
                b = 0;
                textBox2.Text = "";
            }

            float suma, produs, diferenta, cat = 0;
            suma = a + b;
            produs = a * b;
            diferenta = a - b;
            if (b != 0)
            {
                cat = a / b;
            }
            else
            {
                textBox6.Text = "Împărțirea la 0  nu este posibilă";
            }
            textBox3.Text = suma.ToString();
            textBox4.Text = diferenta.ToString();
            textBox5.Text = produs.ToString();
            if(textBox6.Text == "")
                textBox6.Text = cat.ToString();

        }
    }
}
