
namespace diyetisyenUygulamasi
{
    partial class Form_AdminPenceresi
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
            this.tabControl_yonetim = new System.Windows.Forms.TabControl();
            this.tabPage_diyetisyenler = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_yenile = new System.Windows.Forms.Button();
            this.listBox_diyetisyenler = new System.Windows.Forms.ListBox();
            this.tabPage_diyetisyenEkle = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_tckno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_diyetisyenEkle = new System.Windows.Forms.Button();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.tabControl_yonetim.SuspendLayout();
            this.tabPage_diyetisyenler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_diyetisyenEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_yonetim
            // 
            this.tabControl_yonetim.Controls.Add(this.tabPage_diyetisyenler);
            this.tabControl_yonetim.Controls.Add(this.tabPage_diyetisyenEkle);
            this.tabControl_yonetim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_yonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tabControl_yonetim.Location = new System.Drawing.Point(0, 0);
            this.tabControl_yonetim.Name = "tabControl_yonetim";
            this.tabControl_yonetim.SelectedIndex = 0;
            this.tabControl_yonetim.Size = new System.Drawing.Size(570, 497);
            this.tabControl_yonetim.TabIndex = 0;
            // 
            // tabPage_diyetisyenler
            // 
            this.tabPage_diyetisyenler.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_diyetisyenler.Controls.Add(this.groupBox2);
            this.tabPage_diyetisyenler.Location = new System.Drawing.Point(4, 27);
            this.tabPage_diyetisyenler.Name = "tabPage_diyetisyenler";
            this.tabPage_diyetisyenler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_diyetisyenler.Size = new System.Drawing.Size(562, 466);
            this.tabPage_diyetisyenler.TabIndex = 0;
            this.tabPage_diyetisyenler.Text = "Diyetisyenler";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.button_yenile);
            this.groupBox2.Controls.Add(this.listBox_diyetisyenler);
            this.groupBox2.Location = new System.Drawing.Point(26, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 346);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diyetisyenler";
            // 
            // button_yenile
            // 
            this.button_yenile.Location = new System.Drawing.Point(64, 270);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(373, 33);
            this.button_yenile.TabIndex = 7;
            this.button_yenile.Text = "Yenile";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // listBox_diyetisyenler
            // 
            this.listBox_diyetisyenler.FormattingEnabled = true;
            this.listBox_diyetisyenler.ItemHeight = 18;
            this.listBox_diyetisyenler.Items.AddRange(new object[] {
            "1111111",
            "222222222",
            "2333333333",
            "444444"});
            this.listBox_diyetisyenler.Location = new System.Drawing.Point(64, 44);
            this.listBox_diyetisyenler.Name = "listBox_diyetisyenler";
            this.listBox_diyetisyenler.Size = new System.Drawing.Size(373, 220);
            this.listBox_diyetisyenler.TabIndex = 6;
            // 
            // tabPage_diyetisyenEkle
            // 
            this.tabPage_diyetisyenEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_diyetisyenEkle.Controls.Add(this.groupBox1);
            this.tabPage_diyetisyenEkle.Location = new System.Drawing.Point(4, 27);
            this.tabPage_diyetisyenEkle.Name = "tabPage_diyetisyenEkle";
            this.tabPage_diyetisyenEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_diyetisyenEkle.Size = new System.Drawing.Size(562, 466);
            this.tabPage_diyetisyenEkle.TabIndex = 1;
            this.tabPage_diyetisyenEkle.Text = "Diyetisyen Ekle";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textBox_tckno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_diyetisyenEkle);
            this.groupBox1.Controls.Add(this.textBox_parola);
            this.groupBox1.Controls.Add(this.label_parola);
            this.groupBox1.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label_kullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(89, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diyetisyen Ekle";
            // 
            // textBox_tckno
            // 
            this.textBox_tckno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_tckno.Location = new System.Drawing.Point(57, 258);
            this.textBox_tckno.Name = "textBox_tckno";
            this.textBox_tckno.Size = new System.Drawing.Size(237, 24);
            this.textBox_tckno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(54, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "TC Kimlik Numarası:";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_soyad.Location = new System.Drawing.Point(57, 205);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(237, 24);
            this.textBox_soyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(54, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Soyadı:";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_ad.Location = new System.Drawing.Point(57, 157);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(237, 24);
            this.textBox_ad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(54, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Adı:";
            // 
            // button_diyetisyenEkle
            // 
            this.button_diyetisyenEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_diyetisyenEkle.Location = new System.Drawing.Point(57, 302);
            this.button_diyetisyenEkle.Name = "button_diyetisyenEkle";
            this.button_diyetisyenEkle.Size = new System.Drawing.Size(237, 35);
            this.button_diyetisyenEkle.TabIndex = 6;
            this.button_diyetisyenEkle.Text = "Sisteme Diyetisyen Ekle";
            this.button_diyetisyenEkle.UseVisualStyleBackColor = true;
            this.button_diyetisyenEkle.Click += new System.EventHandler(this.button_diyetisyenEkle_Click);
            // 
            // textBox_parola
            // 
            this.textBox_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_parola.Location = new System.Drawing.Point(57, 110);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(237, 24);
            this.textBox_parola.TabIndex = 2;
            this.textBox_parola.UseSystemPasswordChar = true;
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_parola.Location = new System.Drawing.Point(54, 91);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(51, 16);
            this.label_parola.TabIndex = 26;
            this.label_parola.Text = "Parola:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(57, 60);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(237, 24);
            this.textBox_kullaniciAdi.TabIndex = 1;
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_kullaniciAdi.Location = new System.Drawing.Point(54, 41);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(83, 16);
            this.label_kullaniciAdi.TabIndex = 24;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // Form_AdminPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 497);
            this.Controls.Add(this.tabControl_yonetim);
            this.Name = "Form_AdminPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AdminPenceresi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AdminPenceresi_FormClosing);
            this.Load += new System.EventHandler(this.Form_AdminPenceresi_Load);
            this.tabControl_yonetim.ResumeLayout(false);
            this.tabPage_diyetisyenler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage_diyetisyenEkle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_yonetim;
        private System.Windows.Forms.TabPage tabPage_diyetisyenler;
        private System.Windows.Forms.TabPage tabPage_diyetisyenEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_tckno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_diyetisyenEkle;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.ListBox listBox_diyetisyenler;
    }
}