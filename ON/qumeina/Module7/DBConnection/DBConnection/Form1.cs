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

        private void Connect_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();
            MessageBox.Show("Connection Open Successfully");
            myconnection.Close();
        }
    }
}
