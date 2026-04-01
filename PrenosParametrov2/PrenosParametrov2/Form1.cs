using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrenosParametrov2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SetIme(textBox1.Text);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = form2.GetPriimek();
            }
        }
    }
}
