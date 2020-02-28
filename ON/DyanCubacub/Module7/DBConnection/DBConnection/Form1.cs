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

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=myDB;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();
            // MessageBox.Show("Connection Open Successfully!");
            
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            // define SQL statement
            sql = "Select ID, Name from Student";
            // the command statment used to perform operations of reading and writing into the database
            command = new SqlCommand(sql, myconnection);
            // define data reader used to get all the data specified by the SQL query 
            dataReader = command.ExecuteReader();

            // det the table values
            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);

            // good practice to close all the objects related to out database operation
            dataReader.Close();
            command.Dispose();
            myconnection.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=myDB;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();
            
            SqlCommand command;

            // SqlDataAdapter used to perform specific SQL operations such as insert, delete, and update commands.
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Student (ID,Name) values(4, 'Jack' )";
            MessageBox.Show("Added Successfully!");

            command = new SqlCommand(sql, myconnection);

            adapter.InsertCommand = new SqlCommand(sql, myconnection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            myconnection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=myDB;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;

            // SqlDataAdapter used to perform specific SQL operations such as insert, delete, and update commands.
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Update Student set Name= 'Jones' where ID=4";
            MessageBox.Show("Updated Successfully!");

            command = new SqlCommand(sql, myconnection);

            adapter.UpdateCommand = new SqlCommand(sql, myconnection);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            myconnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection myconnection;
            connectionString = "Server=localhost;Database=myDB;Trusted_Connection=True;";
            myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand command;

            // SqlDataAdapter used to perform specific SQL operations such as insert, delete, and update commands.
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
