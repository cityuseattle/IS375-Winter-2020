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

namespace DBCConnection
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
			connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
			myconnection = new SqlConnection(connectionString);
			myconnection.Open();
			MessageBox.Show("Connection Open Successfully!");
			myconnection.Close();

		}
	}
}
