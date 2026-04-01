using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrenosParametrov1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPriimek_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(txtIme.Text);
            if (form2.ShowDialog() == DialogResult.OK)
            {
            txtPriimek.Text = form2.txtPriimek.Text;
            }
        }
    }
}
