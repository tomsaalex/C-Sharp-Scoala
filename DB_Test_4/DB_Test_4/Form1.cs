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

namespace DB_Test_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection conexiune;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            conexiune = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Tomsa\GitHub_Proj\C-Sharp-Scoala\DB_Test_4\DB_Test_4\Database1.mdf;Integrated Security=True");
            conexiune.Open();
        }



        private void displayButton_Click(object sender, EventArgs e)
        {
            string textCommand = "SELECT * FROM Zboruri";
            SqlCommand sqlCommand = conexiune.CreateCommand();
            sqlCommand.CommandText = textCommand;   
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexiune.Close();
        }
        
    }
}
