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

namespace HOP08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection myconnection;
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "Select * from Student";
            command = new SqlCommand(sql, myconnection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            myconnection.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection myconnection;
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Insert into Student (Id, Name) values(4, 'Jack')";

            command = new SqlCommand(sql, myconnection);
            adapter.InsertCommand = new SqlCommand(sql, myconnection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            myconnection.Close();
            MessageBox.Show("Insert Successfully!");          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection myconnection;
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Update Student set Name='Jones' where Id=4";

            command = new SqlCommand(sql, myconnection);
            adapter.InsertCommand = new SqlCommand(sql, myconnection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            myconnection.Close();
            MessageBox.Show("Update Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection myconnection;
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Delete Student where Name='Jones'";

            command = new SqlCommand(sql, myconnection);
            adapter.InsertCommand = new SqlCommand(sql, myconnection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            myconnection.Close();
            MessageBox.Show("Delete Successfully!");
        }
    }
}
