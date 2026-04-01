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
    public partial class Form2 : Form
    {
        public Form2(string ime)
        {
            InitializeComponent();
            txtIme.Text = ime;
            txtPriimek.Focus();
        }
    }
}
