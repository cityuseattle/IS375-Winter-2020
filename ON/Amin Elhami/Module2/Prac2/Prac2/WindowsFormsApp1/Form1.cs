using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows0
{
    public class Form1: Form
    {
        public Form1()
        {
            Text = "Simple Application";
        }
        
        static void Main()
        {
            Form1 winForm = new Form1();
            Application.Run(winForm);
        }
    }
}
