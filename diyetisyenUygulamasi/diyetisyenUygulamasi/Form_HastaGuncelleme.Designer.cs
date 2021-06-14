
namespace diyetisyenUygulamasi
{
    partial class Form_HastaGuncelleme
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
        private void InitializeComponent(bool yetki)
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_hastalikDegis = new System.Windows.Forms.Button();

            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hastalik = new System.Windows.Forms.ComboBox();
            this.textBox_tckno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_diyetBilgi = new System.Windows.Forms.RichTextBox();
            this.button_diyetDegis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_diyet = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_raporTypeHTML = new System.Windows.Forms.RadioButton();
            this.radioButton_raporTypeJSON = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_raporDuzenHD = new System.Windows.Forms.RadioButton();
            this.radioButton_raporDuzenDH = new System.Windows.Forms.RadioButton();
            this.button_raporla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label10);
            if (yetki)
                this.groupBox1.Controls.Add(this.button_hastalikDegis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_hastalik);
            this.groupBox1.Controls.Add(this.textBox_tckno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 265);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kişisel Bilgileri";

            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.richTextBox_diyetBilgi);
            if (yetki)
                this.groupBox2.Controls.Add(this.button_diyetDegis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_diyet);
            this.groupBox2.Location = new System.Drawing.Point(42, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 242);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diyet Bilgileri";

            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(21, 217);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.ReadOnly = true;
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(398, 24);
            this.textBox_kullaniciAdi.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label10.Location = new System.Drawing.Point(18, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Kullanıcı Adı:";
            // 
            // button_hastalikDegis
            // 
            this.button_hastalikDegis.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button_hastalikDegis.Location = new System.Drawing.Point(425, 161);
            this.button_hastalikDegis.Name = "button_hastalikDegis";
            this.button_hastalikDegis.Size = new System.Drawing.Size(56, 26);
            this.button_hastalikDegis.TabIndex = 5;
            this.button_hastalikDegis.Text = "Değiştir";
            this.button_hastalikDegis.UseVisualStyleBackColor = true;
            this.button_hastalikDegis.Click += new System.EventHandler(this.button_hastalikDegis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hastalık:";
            // 
            // comboBox_hastalik
            // 
            this.comboBox_hastalik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hastalik.Enabled = false;
            this.comboBox_hastalik.FormattingEnabled = true;
            this.comboBox_hastalik.Location = new System.Drawing.Point(21, 161);
            this.comboBox_hastalik.Name = "comboBox_hastalik";
            this.comboBox_hastalik.Size = new System.Drawing.Size(398, 26);
            this.comboBox_hastalik.TabIndex = 4;
            // 
            // textBox_tckno
            // 
            this.textBox_tckno.Location = new System.Drawing.Point(21, 108);
            this.textBox_tckno.Name = "textBox_tckno";
            this.textBox_tckno.ReadOnly = true;
            this.textBox_tckno.Size = new System.Drawing.Size(398, 24);
            this.textBox_tckno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC Kimlik No:";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(223, 55);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.ReadOnly = true;
            this.textBox_soyad.Size = new System.Drawing.Size(196, 24);
            this.textBox_soyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(220, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı:";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(21, 55);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.ReadOnly = true;
            this.textBox_ad.Size = new System.Drawing.Size(196, 24);
            this.textBox_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı:";

            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Diyet Bilgi:";
            // 
            // richTextBox_diyetBilgi
            // 
            this.richTextBox_diyetBilgi.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_diyetBilgi.Location = new System.Drawing.Point(21, 111);
            this.richTextBox_diyetBilgi.Name = "richTextBox_diyetBilgi";
            this.richTextBox_diyetBilgi.ReadOnly = true;
            this.richTextBox_diyetBilgi.Size = new System.Drawing.Size(398, 111);
            this.richTextBox_diyetBilgi.TabIndex = 8;
            this.richTextBox_diyetBilgi.Text = "";
            // 
            // button_diyetDegis
            // 
            this.button_diyetDegis.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button_diyetDegis.Location = new System.Drawing.Point(425, 55);
            this.button_diyetDegis.Name = "button_diyetDegis";
            this.button_diyetDegis.Size = new System.Drawing.Size(56, 26);
            this.button_diyetDegis.TabIndex = 7;
            this.button_diyetDegis.Text = "Değiştir";
            this.button_diyetDegis.UseVisualStyleBackColor = true;
            this.button_diyetDegis.Click += new System.EventHandler(this.button_diyetDegis_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(18, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Diyet:";
            // 
            // comboBox_diyet
            // 
            this.comboBox_diyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_diyet.Enabled = false;
            this.comboBox_diyet.FormattingEnabled = true;
            this.comboBox_diyet.Location = new System.Drawing.Point(21, 55);
            this.comboBox_diyet.Name = "comboBox_diyet";
            this.comboBox_diyet.Size = new System.Drawing.Size(398, 26);
            this.comboBox_diyet.TabIndex = 6;
            this.comboBox_diyet.SelectedIndexChanged += new System.EventHandler(this.comboBox_diyet_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_raporla);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(42, 569);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 175);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapor İşlemleri";
            // 
            // radioButton_raporTypeHTML
            // 
            this.radioButton_raporTypeHTML.AutoSize = true;
            this.radioButton_raporTypeHTML.Checked = true;
            this.radioButton_raporTypeHTML.Location = new System.Drawing.Point(24, 34);
            this.radioButton_raporTypeHTML.Name = "radioButton_raporTypeHTML";
            this.radioButton_raporTypeHTML.Size = new System.Drawing.Size(67, 22);
            this.radioButton_raporTypeHTML.TabIndex = 14;
            this.radioButton_raporTypeHTML.TabStop = true;
            this.radioButton_raporTypeHTML.Text = "HTML";
            this.radioButton_raporTypeHTML.UseVisualStyleBackColor = true;
            // 
            // radioButton_raporTypeJSON
            // 
            this.radioButton_raporTypeJSON.AutoSize = true;
            this.radioButton_raporTypeJSON.Location = new System.Drawing.Point(129, 34);
            this.radioButton_raporTypeJSON.Name = "radioButton_raporTypeJSON";
            this.radioButton_raporTypeJSON.Size = new System.Drawing.Size(67, 22);
            this.radioButton_raporTypeJSON.TabIndex = 15;
            this.radioButton_raporTypeJSON.Text = "JSON";
            this.radioButton_raporTypeJSON.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_raporTypeHTML);
            this.groupBox4.Controls.Add(this.radioButton_raporTypeJSON);
            this.groupBox4.Location = new System.Drawing.Point(10, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 87);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Format";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_raporDuzenHD);
            this.groupBox5.Controls.Add(this.radioButton_raporDuzenDH);
            this.groupBox5.Location = new System.Drawing.Point(238, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 87);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Düzen";
            // 
            // radioButton_raporDuzenHD
            // 
            this.radioButton_raporDuzenHD.AutoSize = true;
            this.radioButton_raporDuzenHD.Checked = true;
            this.radioButton_raporDuzenHD.Location = new System.Drawing.Point(6, 25);
            this.radioButton_raporDuzenHD.Name = "radioButton_raporDuzenHD";
            this.radioButton_raporDuzenHD.Size = new System.Drawing.Size(119, 40);
            this.radioButton_raporDuzenHD.TabIndex = 14;
            this.radioButton_raporDuzenHD.TabStop = true;
            this.radioButton_raporDuzenHD.Text = "Hasta Bilgileri \r\nDiyet Bilgileri";
            this.radioButton_raporDuzenHD.UseVisualStyleBackColor = true;
            // 
            // radioButton_raporDuzenDH
            // 
            this.radioButton_raporDuzenDH.AutoSize = true;
            this.radioButton_raporDuzenDH.Location = new System.Drawing.Point(126, 25);
            this.radioButton_raporDuzenDH.Name = "radioButton_raporDuzenDH";
            this.radioButton_raporDuzenDH.Size = new System.Drawing.Size(115, 40);
            this.radioButton_raporDuzenDH.TabIndex = 15;
            this.radioButton_raporDuzenDH.Text = "Diyet Bilgileri\r\nHasta Bilgileri";
            this.radioButton_raporDuzenDH.UseVisualStyleBackColor = true;
            // 
            // button_raporla
            // 
            this.button_raporla.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button_raporla.Location = new System.Drawing.Point(12, 128);
            this.button_raporla.Name = "button_raporla";
            this.button_raporla.Size = new System.Drawing.Size(469, 26);
            this.button_raporla.TabIndex = 17;
            this.button_raporla.Text = "Raporla";
            this.button_raporla.UseVisualStyleBackColor = true;
            this.button_raporla.Click += new System.EventHandler(this.button_raporla_Click);
            // 
            // Form_HastaGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 758);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(593, 736);
            this.Name = "Form_HastaGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.Form_HastaGuncelleme_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_HastaGuncelleme_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_tckno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hastalikDegis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_hastalik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_diyetBilgi;
        private System.Windows.Forms.Button button_diyetDegis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_diyet;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_raporla;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_raporDuzenHD;
        private System.Windows.Forms.RadioButton radioButton_raporDuzenDH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton_raporTypeHTML;
        private System.Windows.Forms.RadioButton radioButton_raporTypeJSON;
    }
}