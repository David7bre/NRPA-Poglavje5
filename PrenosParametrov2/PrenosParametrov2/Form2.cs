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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.Focus();
        }

        public void SetIme(string ime)
        {
            textBox1.Text = ime;
        }

        public string GetPriimek()
        {
            return textBox2.Text; 
        }
    }
}
