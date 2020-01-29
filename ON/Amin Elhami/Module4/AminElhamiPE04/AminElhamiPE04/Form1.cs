using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AminElhamiPE04
{
 
    public partial class Form1 : Form
    {
        public string mes = "Selected items: "+Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
        }

        private void skis_CheckedChanged(object sender, EventArgs e)
        {
            if (skis.Checked)
            {
                mes += "Skis" + Environment.NewLine;
            }
        }

        private void gloves_CheckedChanged(object sender, EventArgs e)
        {
            if (gloves.Checked)
            {
                mes += "Snow Gloves" + Environment.NewLine;
            }
        }

        private void goggles_CheckedChanged(object sender, EventArgs e)
        {
            if (goggles.Checked)
            {
                mes += "Goggles" + Environment.NewLine;
            }
        }

        private void earmuffs_CheckedChanged(object sender, EventArgs e)
        {
            if (earmuffs.Checked)
            {
                mes += "Earmuffs" + Environment.NewLine;
            }
        }

        private void helmet_CheckedChanged(object sender, EventArgs e)
        {
            if (helmet.Checked)
            {
                mes += "Helmet" + Environment.NewLine;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            if (skis.Checked)
            {
                skis.Checked = false;
            }
            if (gloves.Checked)
            {
                gloves.Checked = false;
            }
            if (goggles.Checked)
            {
                goggles.Checked = false;
            }
            if (earmuffs.Checked)
            {
                earmuffs.Checked = false;
            }
            if (helmet.Checked)
            {
                helmet.Checked = false;
            }
            mes = "Selected items: " + Environment.NewLine;
        }
        private void display_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mes);
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
