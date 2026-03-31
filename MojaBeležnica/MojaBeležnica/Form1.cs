using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaBeležnica
{
    public partial class Form1: Form
    {
        private string file;

        public string File
        {
            get { return file; }
            set { file = value; }
        }

        public Form1()
        {
            InitializeComponent();
            this.File = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",
                 "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Cancel) return;
                else if (res == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    return;
                }
            }

            File = string.Empty;
            openFileDialog1.FileName = File;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.File = openFileDialog1.FileName;
                    this.Text = "Moja beležnica - " + File;
                    richTextBox1.LoadFile(this.File, RichTextBoxStreamType.PlainText);
                    richTextBox1.Modified = false;
                }
            }
            catch (Exception ex)
            {
                string fileName = System.IO.Path.GetFileName(File);
                MessageBox.Show("Datoteke " + fileName + " ni bilo mogoče odpreti.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(File))
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            if (!richTextBox1.Modified) return;

            try
            {
                richTextBox1.SaveFile(this.File, RichTextBoxStreamType.PlainText);
                richTextBox1.Modified = false;
            }
            catch (Exception ex)
            {
                string fileName = System.IO.Path.GetFileName(File);
                MessageBox.Show("Datoteke " + fileName + " ni bilo mogoče shraniti.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = File;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    File = saveFileDialog1.FileName;
                    this.Text = "Moja beležnica - " + File;
                    richTextBox1.Modified = false;
                }
            }
            catch (Exception ex)
            {
                string fileName = System.IO.Path.GetFileName(File);
                MessageBox.Show("Datoteke " + fileName + " ni bilo mogoče shraniti.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",
                 "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Cancel) return;
                else if (res == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    return;
                }
            }

            File = string.Empty;
            richTextBox1.Clear();
            this.Text = "Moja beležnica";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",
                 "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Cancel) e.Cancel = true;
                else if (res == DialogResult.Yes) saveToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
