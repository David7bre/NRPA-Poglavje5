using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRaztegni_Click(object sender, EventArgs e)
        {
            if (pictureBoxSlika.SizeMode == PictureBoxSizeMode.Normal)
                pictureBoxSlika.SizeMode = PictureBoxSizeMode.Zoom;
            else pictureBoxSlika.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPot.Text = openFileDialog1.FileName;
                    this.Text = "Slika - " + openFileDialog1.FileName;
                    pictureBoxSlika.ImageLocation = openFileDialog1.FileName;
                }
                else
                {
                    txtPot.Text = "Datoteka ni bila izbrana!";
                    this.Text = "Slika";
                    pictureBoxSlika.Image= null;
                }
            }
            catch (Exception ex)
            {
                this.Text = "Slika";
                pictureBoxSlika.Image = null;
                MessageBox.Show("Izbrane datoteke ne morem prikazati v PictureBoxu.", "Napaka",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
