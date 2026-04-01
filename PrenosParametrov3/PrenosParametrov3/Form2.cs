using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrenosParametrov3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.Focus();
        }

        internal string Priimek
        {
            get {  return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        internal string Ime
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
