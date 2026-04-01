namespace PrenosParametrov5
{
    partial class Prijava
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
            this.txtStaroGeslo = new System.Windows.Forms.Label();
            this.txtNovoGeslo = new System.Windows.Forms.Label();
            this.txtNovoGeslo2 = new System.Windows.Forms.Label();
            this.txtBoxNovo = new System.Windows.Forms.TextBox();
            this.txtBoxNovo2 = new System.Windows.Forms.TextBox();
            this.txtBoxStaro = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStaroGeslo
            // 
            this.txtStaroGeslo.AutoSize = true;
            this.txtStaroGeslo.Location = new System.Drawing.Point(24, 23);
            this.txtStaroGeslo.Name = "txtStaroGeslo";
            this.txtStaroGeslo.Size = new System.Drawing.Size(63, 13);
            this.txtStaroGeslo.TabIndex = 0;
            this.txtStaroGeslo.Text = "Staro geslo:";
            // 
            // txtNovoGeslo
            // 
            this.txtNovoGeslo.AutoSize = true;
            this.txtNovoGeslo.Location = new System.Drawing.Point(24, 81);
            this.txtNovoGeslo.Name = "txtNovoGeslo";
            this.txtNovoGeslo.Size = new System.Drawing.Size(64, 13);
            this.txtNovoGeslo.TabIndex = 1;
            this.txtNovoGeslo.Text = "Novo geslo:";
            // 
            // txtNovoGeslo2
            // 
            this.txtNovoGeslo2.AutoSize = true;
            this.txtNovoGeslo2.Location = new System.Drawing.Point(24, 141);
            this.txtNovoGeslo2.Name = "txtNovoGeslo2";
            this.txtNovoGeslo2.Size = new System.Drawing.Size(89, 13);
            this.txtNovoGeslo2.TabIndex = 2;
            this.txtNovoGeslo2.Text = "Potrdi novo geslo";
            // 
            // txtBoxNovo
            // 
            this.txtBoxNovo.Location = new System.Drawing.Point(27, 97);
            this.txtBoxNovo.Name = "txtBoxNovo";
            this.txtBoxNovo.PasswordChar = '*';
            this.txtBoxNovo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNovo.TabIndex = 5;
            // 
            // txtBoxNovo2
            // 
            this.txtBoxNovo2.Location = new System.Drawing.Point(27, 157);
            this.txtBoxNovo2.Name = "txtBoxNovo2";
            this.txtBoxNovo2.PasswordChar = '*';
            this.txtBoxNovo2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNovo2.TabIndex = 6;
            // 
            // txtBoxStaro
            // 
            this.txtBoxStaro.Location = new System.Drawing.Point(27, 39);
            this.txtBoxStaro.Name = "txtBoxStaro";
            this.txtBoxStaro.PasswordChar = '*';
            this.txtBoxStaro.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStaro.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(27, 183);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(27, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Prijava
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 255);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBoxStaro);
            this.Controls.Add(this.txtBoxNovo2);
            this.Controls.Add(this.txtBoxNovo);
            this.Controls.Add(this.txtNovoGeslo2);
            this.Controls.Add(this.txtNovoGeslo);
            this.Controls.Add(this.txtStaroGeslo);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStaroGeslo;
        private System.Windows.Forms.Label txtNovoGeslo;
        private System.Windows.Forms.Label txtNovoGeslo2;
        internal System.Windows.Forms.TextBox txtBoxNovo;
        internal System.Windows.Forms.TextBox txtBoxNovo2;
        internal System.Windows.Forms.TextBox txtBoxStaro;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}