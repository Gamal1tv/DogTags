using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "" || txtSurname.Text == "" || txtAddress.Text == "" || cboxBlood.Text == "")
            {

            }
            else
            {
                dgridTags.Rows.Add(txtSurname.Text, txtFirstname.Text, txtAddress.Text, cboxBlood.Text);
                txtSurname.Clear();
                txtFirstname.Clear();
                txtAddress.Clear();
                cboxBlood.Text = " ";
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgridTags.Rows.Count > 0)
            {
                dgridTags.Rows.RemoveAt(dgridTags.CurrentRow.Index);
            }
            
        }
    }
}
