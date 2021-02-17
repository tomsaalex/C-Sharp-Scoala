using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Test_1
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection conexiune;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //definire conexiune
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Tomsa\GitHub_Proj\C-Sharp-Scoala\DB_Test_1\DB_Test_1\Asociatie.mdf;Integrated Security=True";
            conexiune = new SqlConnection(connectionString);
            
            //deschidere conexiune
            conexiune.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //inchidere conexiune
            conexiune.Close();
        }

        private void buttonAfisareLocatari_Click(object sender, EventArgs e)
        {
            //extragere si aranjare data

            SqlCommand comanda = new SqlCommand("SELECT * FROM Locatari", conexiune);
            SqlDataAdapter da = new SqlDataAdapter(comanda);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //afisare
            dataGridView1.DataSource = dt;
        }

        private void butonAfisareAngajati_Click(object sender, EventArgs e)
        {
            //extragere si aranjare data

            SqlCommand comanda = new SqlCommand("SELECT * FROM Locatari WHERE angajat = 'True'", conexiune);
            SqlDataAdapter da = new SqlDataAdapter(comanda);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //afisare
            dataGridView1.DataSource = dt;
        }
    }
}
