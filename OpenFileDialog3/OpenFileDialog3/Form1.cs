using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    this.Text = "Moja beležnica - " + fileName;
                }
            }
            catch (Exception ex)
            {
                fileName = System.IO.Path.GetFileName(fileName);
                MessageBox.Show("Datoteke " + openFileDialog1.FileName + " ni bilo mogoče odpreti.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
