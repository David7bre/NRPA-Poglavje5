using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrenosParametrov5
{
    public partial class Form1 : Form
    {
        Prijavaaa prijavnoOkno;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            prijavnoOkno = new Prijavaaa();
            prijavnoOkno.ShowDialog();
            label1.Text = "Pozdravljen " + prijavnoOkno.txtBoxIme.Text + ". Tvoje geslo je " + prijavnoOkno.txtBoxGeslo.Text;
        }

        private void btnSpremeniGeslo_Click(object sender, EventArgs e)
        {
            Prijava spremembaGeslaOkno = new Prijava();
            if (spremembaGeslaOkno.ShowDialog() == DialogResult.OK
                && spremembaGeslaOkno.txtBoxStaro.Text == prijavnoOkno.txtBoxGeslo.Text
                && spremembaGeslaOkno.txtBoxNovo.Text == spremembaGeslaOkno.txtBoxNovo2.Text)
            {
                prijavnoOkno.txtBoxGeslo.Text = spremembaGeslaOkno.txtBoxNovo.Text;
                label1.Text = "Pozdravljen " + prijavnoOkno.txtBoxIme.Text + ". Tvoje geslo je " + spremembaGeslaOkno.txtBoxNovo.Text;
                label2.Text = "Geslo je bilo uspešno spremenjeno. \r\nNovo geslo je izpisano zgoraj.";
            } else
            {
                label2.Text = "Geslo ni bilo spremenjeno.";
            }
        }
    }
}
