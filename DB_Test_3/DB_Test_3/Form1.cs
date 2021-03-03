using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Test_3
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Tomsa\GitHub_Proj\C-Sharp-Scoala\DB_Test_3\DB_Test_3\Database1.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        void Afisare(string txtComanda)
        {
            string textCommand;
            if (txtComanda != null)
                textCommand = txtComanda;
            else
                textCommand = "SELECT * FROM Produse";
            SqlCommand command = new SqlCommand(textCommand, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afisare(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string denumire;
            int cod;
            float pret;
            string datain;

            SqlCommand sqlCommand;

            try
            {
                denumire = denumireBox.Text;
                cod = int.Parse(codBox.Text);
                pret = float.Parse(pretBox.Text);
                datain = dataBox.Text;

                string cmdtxt = $"INSERT INTO Produse(cod, denumirea, pret, data_in) VALUES({cod}, '{denumire}', {pret}, '{datain}')";
                sqlCommand = new SqlCommand(cmdtxt, connection);
                sqlCommand.ExecuteNonQuery();
                Afisare(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare = " + ex.Message);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float pretMic = int.Parse(pretMicBox.Text);
            float pretMare = int.Parse(pretMareBox.Text);

            string textCommand = $"SELECT * FROM Produse WHERE pret <= {pretMare} AND pret >= {pretMic}";
            
            Afisare(textCommand);

        }
    }
}
