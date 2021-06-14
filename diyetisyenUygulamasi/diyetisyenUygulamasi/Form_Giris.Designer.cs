
namespace diyetisyenUygulamasi
{
    partial class Form_Giris
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
            this.groupBox_giris = new System.Windows.Forms.GroupBox();
            this.button_hastaGiris = new System.Windows.Forms.Button();
            this.button_diyetisyenGiris = new System.Windows.Forms.Button();
            this.button_adminGiris = new System.Windows.Forms.Button();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.groupBox_giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_giris
            // 
            this.groupBox_giris.Controls.Add(this.button_hastaGiris);
            this.groupBox_giris.Controls.Add(this.button_diyetisyenGiris);
            this.groupBox_giris.Controls.Add(this.button_adminGiris);
            this.groupBox_giris.Controls.Add(this.textBox_parola);
            this.groupBox_giris.Controls.Add(this.label_parola);
            this.groupBox_giris.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox_giris.Controls.Add(this.label_kullaniciAdi);
            this.groupBox_giris.Location = new System.Drawing.Point(40, 38);
            this.groupBox_giris.Name = "groupBox_giris";
            this.groupBox_giris.Size = new System.Drawing.Size(265, 308);
            this.groupBox_giris.TabIndex = 2;
            this.groupBox_giris.TabStop = false;
            // 
            // button_hastaGiris
            // 
            this.button_hastaGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hastaGiris.Location = new System.Drawing.Point(32, 233);
            this.button_hastaGiris.Name = "button_hastaGiris";
            this.button_hastaGiris.Size = new System.Drawing.Size(202, 35);
            this.button_hastaGiris.TabIndex = 13;
            this.button_hastaGiris.Text = "Hasta Olarak Gir";
            this.button_hastaGiris.UseVisualStyleBackColor = true;
            this.button_hastaGiris.Click += new System.EventHandler(this.button_hastaGiris_Click);
            // 
            // button_diyetisyenGiris
            // 
            this.button_diyetisyenGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_diyetisyenGiris.Location = new System.Drawing.Point(32, 192);
            this.button_diyetisyenGiris.Name = "button_diyetisyenGiris";
            this.button_diyetisyenGiris.Size = new System.Drawing.Size(202, 35);
            this.button_diyetisyenGiris.TabIndex = 12;
            this.button_diyetisyenGiris.Text = "Diyetisyen Olarak Gir";
            this.button_diyetisyenGiris.UseVisualStyleBackColor = true;
            this.button_diyetisyenGiris.Click += new System.EventHandler(this.button_diyetisyenGiris_Click);
            // 
            // button_adminGiris
            // 
            this.button_adminGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adminGiris.Location = new System.Drawing.Point(32, 151);
            this.button_adminGiris.Name = "button_adminGiris";
            this.button_adminGiris.Size = new System.Drawing.Size(202, 35);
            this.button_adminGiris.TabIndex = 11;
            this.button_adminGiris.Text = "Admin Olarak Gir";
            this.button_adminGiris.UseVisualStyleBackColor = true;
            this.button_adminGiris.Click += new System.EventHandler(this.button_adminGiris_Click);
            // 
            // textBox_parola
            // 
            this.textBox_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_parola.Location = new System.Drawing.Point(34, 111);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(202, 24);
            this.textBox_parola.TabIndex = 9;
            this.textBox_parola.UseSystemPasswordChar = true;
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_parola.Location = new System.Drawing.Point(31, 95);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(51, 16);
            this.label_parola.TabIndex = 10;
            this.label_parola.Text = "Parola:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(32, 61);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(202, 24);
            this.textBox_kullaniciAdi.TabIndex = 7;
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_kullaniciAdi.Location = new System.Drawing.Point(29, 45);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(83, 16);
            this.label_kullaniciAdi.TabIndex = 8;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 397);
            this.Controls.Add(this.groupBox_giris);
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Giris";
            this.groupBox_giris.ResumeLayout(false);
            this.groupBox_giris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_giris;
        private System.Windows.Forms.Button button_hastaGiris;
        private System.Windows.Forms.Button button_diyetisyenGiris;
        private System.Windows.Forms.Button button_adminGiris;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label_kullaniciAdi;
    }
}