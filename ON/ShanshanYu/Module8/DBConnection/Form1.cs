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
      string Connectionstring = "Server=localhost;Database=testDB;Trusted_Connection=True;";
      SqlConnection myconnection;
      string sql, Output = "";
      public Form1()
      {
         InitializeComponent();
      }

        private void button1_Click(object sender, EventArgs e)
        {

         myconnection = new SqlConnection(Connectionstring);
         myconnection.Open();
         //MessageBox.Show("Conncetion Open Successfully!");

         SqlCommand command;
         SqlDataReader dataReader;
         


         sql = "SELECT ID,Name FROM Student;";
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

      private void update_Click(object sender, EventArgs e)
      {
         myconnection = new SqlConnection(Connectionstring);
         myconnection.Open();
         SqlCommand command;
         SqlDataAdapter adapter = new SqlDataAdapter();

         sql = "Update Student set Name='Jones' Where ID=4;";
         MessageBox.Show("Updated Successfully!");

         command = new SqlCommand(sql, myconnection);

         adapter.UpdateCommand = new SqlCommand(sql, myconnection);
         adapter.UpdateCommand.ExecuteNonQuery();

         command.Dispose();
         myconnection.Close();
      }

      private void delete_Click(object sender, EventArgs e)
      {
         SqlConnection myconnection;
         myconnection = new SqlConnection(Connectionstring);
         myconnection.Open();
         SqlCommand command;

         SqlDataAdapter adapter = new SqlDataAdapter();

         sql = "Delete Student Where Name='Jones';";
         MessageBox.Show("Deleted Successfully!");

         command = new SqlCommand(sql, myconnection);

         adapter.DeleteCommand = new SqlCommand(sql, myconnection);
         adapter.DeleteCommand.ExecuteNonQuery();

         command.Dispose();
         myconnection.Close();

      }

      private void insert_Click(object sender, EventArgs e)
      {
         SqlConnection myconnection;
         myconnection = new SqlConnection(Connectionstring);
         myconnection.Open();
         SqlCommand command;

         SqlDataAdapter adapter = new SqlDataAdapter();

         sql = "Insert into Student(Id,Name) values(4,'Jack');";
         MessageBox.Show("Added Successfully!");

         command = new SqlCommand(sql, myconnection);

         adapter.InsertCommand = new SqlCommand(sql, myconnection);
         adapter.InsertCommand.ExecuteNonQuery();

         command.Dispose();
         myconnection.Close();

      }
   }
}
