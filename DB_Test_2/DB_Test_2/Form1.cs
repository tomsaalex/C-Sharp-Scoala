using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Test_2
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void butonAfisareTot_Click(object sender, EventArgs e)
        {
            string textComandaSQL = "SELECT * FROM Carti";
            SqlCommand command = new SqlCommand(textComandaSQL, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //deschidere conexiune DB
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Tomsa\GitHub_Proj\C-Sharp-Scoala\DB_Test_2\DB_Test_2\Biblioteca.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
        void AfisareDate()
        {
            string textComandaSQL = "SELECT * FROM Carti";
            SqlCommand command = new SqlCommand(textComandaSQL, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void butonAfisareNVolume_Click(object sender, EventArgs e)
        {
            int nrVol = int.Parse(textBox1.Text);
            string textComandaSQL = "";
            try
            {
                textComandaSQL = "SELECT * FROM Carti WHERE nr_vol=" + nrVol;

                SqlCommand command = new SqlCommand(textComandaSQL, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Trebuie sa introduci un numar valid de volume");
            }
        }

        private void butonInserare_Click(object sender, EventArgs e)
        {

            string titlu = textBoxTitlu.Text;
            string autor = textBoxAutor.Text;
            string isbn = textBoxISBN.Text;
            int volume = int.Parse(textBoxNrVol.Text);
            int an_ap = int.Parse(textBoxAnAp.Text);

            string textComandaSQL = "";
            try
            {
                textComandaSQL = $"INSERT INTO Carti (isbn, autorul, titlul, anul_ap, nr_vol) VALUES('{isbn}', '{autor}', '{titlu}', {an_ap}, {volume})";
                
                SqlCommand command = new SqlCommand(textComandaSQL, connection);
                command.ExecuteNonQuery();

            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Toate campurile sunt obligatorii!!!! (EROARE: {ex.Message})");
                
            }
            AfisareDate();
        }
    }
}

