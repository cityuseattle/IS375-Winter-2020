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
            SqlConnection connection;
            connectionString = "Server=localhost;Database=testDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();
            //MessageBox.Show("Connection Open Successfully");

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select ID, Name from Student";

            command = new SqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection connection;
            connectionString = "Server=localhost;Database=testDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command;

            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Student (ID,Name) values (4,'Jack')";
            MessageBox.Show("Added Successfully");

            command = new SqlCommand(sql, connection);

            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection connection;
            connectionString = "Server=localhost;Database=testDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command;

            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Update Student set Name='Jones' where ID=4";
            MessageBox.Show("Updated Successfully");

            command = new SqlCommand(sql, connection);

            adapter.UpdateCommand = new SqlCommand(sql, connection);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection connection;
            connectionString = "Server=localhost;Database=testDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command;

            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Delete Student where Name='Jones'";
            MessageBox.Show("Deleted Successfully");

            command = new SqlCommand(sql, connection);

            adapter.DeleteCommand = new SqlCommand(sql, connection);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }
    }
}
