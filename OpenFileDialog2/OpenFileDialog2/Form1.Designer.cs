namespace OpenFileDialog2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.btnOdpri = new System.Windows.Forms.Button();
            this.btnRaztegni = new System.Windows.Forms.Button();
            this.labelPot = new System.Windows.Forms.Label();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(559, 306);
            this.pictureBoxSlika.TabIndex = 0;
            this.pictureBoxSlika.TabStop = false;
            // 
            // btnOdpri
            // 
            this.btnOdpri.Location = new System.Drawing.Point(577, 12);
            this.btnOdpri.Name = "btnOdpri";
            this.btnOdpri.Size = new System.Drawing.Size(99, 23);
            this.btnOdpri.TabIndex = 1;
            this.btnOdpri.Text = "&Odpri sliko";
            this.btnOdpri.UseVisualStyleBackColor = true;
            this.btnOdpri.Click += new System.EventHandler(this.btnOdpri_Click);
            // 
            // btnRaztegni
            // 
            this.btnRaztegni.Location = new System.Drawing.Point(577, 41);
            this.btnRaztegni.Name = "btnRaztegni";
            this.btnRaztegni.Size = new System.Drawing.Size(99, 23);
            this.btnRaztegni.TabIndex = 2;
            this.btnRaztegni.Text = "&Raztegni/Skrči";
            this.btnRaztegni.UseVisualStyleBackColor = true;
            this.btnRaztegni.Click += new System.EventHandler(this.btnRaztegni_Click);
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.Location = new System.Drawing.Point(12, 321);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(86, 13);
            this.labelPot.TabIndex = 3;
            this.labelPot.Text = "Pot do datoteke:";
            // 
            // txtPot
            // 
            this.txtPot.Location = new System.Drawing.Point(12, 337);
            this.txtPot.Name = "txtPot";
            this.txtPot.ReadOnly = true;
            this.txtPot.Size = new System.Drawing.Size(559, 20);
            this.txtPot.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|GIF (*.gif)|*.gif|Vse slik" +
    "e (*.bmp, *.jpg, *.jpeg, *.gif)|*.bmp;*.jpg;*.jpeg;*.gif;";
            this.openFileDialog1.Title = "Slika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 371);
            this.Controls.Add(this.txtPot);
            this.Controls.Add(this.labelPot);
            this.Controls.Add(this.btnRaztegni);
            this.Controls.Add(this.btnOdpri);
            this.Controls.Add(this.pictureBoxSlika);
            this.Name = "Form1";
            this.Text = "Slika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button btnOdpri;
        private System.Windows.Forms.Button btnRaztegni;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

