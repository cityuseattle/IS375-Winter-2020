using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=Amin2;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select ID, Name from Student";
            command = new SqlCommand(sql, myconnection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            myconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=Amin2;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Student (ID, Name) values (4, 'Jack')";
            MessageBox.Show("Added Successfully!");

            command = new SqlCommand(sql, myconnection);

            adapter.InsertCommand = new SqlCommand(sql, myconnection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            myconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=Amin2;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Update Student set Name='Jones' where ID=4";
            MessageBox.Show("Added Successfully!");

            command = new SqlCommand(sql, myconnection);

            adapter.UpdateCommand = new SqlCommand(sql, myconnection);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            myconnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=Amin2;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Delete Student where Name='Jones'";
            MessageBox.Show("Deleted Successfully!");

            command = new SqlCommand(sql, myconnection);

            adapter.DeleteCommand = new SqlCommand(sql, myconnection);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            myconnection.Close();
        }
    }
}
