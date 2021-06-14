
namespace diyetisyenUygulamasi
{
    partial class Form_DiyetisyenPenceresi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_hastalar = new System.Windows.Forms.TabPage();
            this.button_yenile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_diyetTittle = new System.Windows.Forms.Label();
            this.label_hastalikValue = new System.Windows.Forms.Label();
            this.label_HastalikTittle = new System.Windows.Forms.Label();
            this.label_hastaTcknoValue = new System.Windows.Forms.Label();
            this.label_hastaTcknoTittle = new System.Windows.Forms.Label();
            this.label_hastaAdiValue = new System.Windows.Forms.Label();
            this.label_hastaAdiTittle = new System.Windows.Forms.Label();
            this.tabPage_hastaEkle = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_diyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_hastalik = new System.Windows.Forms.ComboBox();
            this.textBox_tckno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_hastaEkle = new System.Windows.Forms.Button();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.pictureBox_hastaResmi = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_diyetisyen = new System.Windows.Forms.PictureBox();
            this.label_diyetisyenAdi = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_hastalar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_hastaEkle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hastaResmi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_diyetisyen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_hastalar);
            this.tabControl1.Controls.Add(this.tabPage_hastaEkle);
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_hastalar
            // 
            this.tabPage_hastalar.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_hastalar.Controls.Add(this.button_yenile);
            this.tabPage_hastalar.Controls.Add(this.groupBox1);
            this.tabPage_hastalar.Location = new System.Drawing.Point(4, 27);
            this.tabPage_hastalar.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_hastalar.Name = "tabPage_hastalar";
            this.tabPage_hastalar.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_hastalar.Size = new System.Drawing.Size(437, 474);
            this.tabPage_hastalar.TabIndex = 1;
            this.tabPage_hastalar.Text = "Hastalar";
            // 
            // button_yenile
            // 
            this.button_yenile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_yenile.Location = new System.Drawing.Point(8, 433);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(408, 34);
            this.button_yenile.TabIndex = 3;
            this.button_yenile.Text = "Yenile";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 407);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_diyetTittle);
            this.panel1.Controls.Add(this.label_hastalikValue);
            this.panel1.Controls.Add(this.label_HastalikTittle);
            this.panel1.Controls.Add(this.label_hastaTcknoValue);
            this.panel1.Controls.Add(this.label_hastaTcknoTittle);
            this.panel1.Controls.Add(this.label_hastaAdiValue);
            this.panel1.Controls.Add(this.label_hastaAdiTittle);
            this.panel1.Controls.Add(this.pictureBox_hastaResmi);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 128);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "muzohamigil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(234, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yeşillikler Dünyası";
            // 
            // label_diyetTittle
            // 
            this.label_diyetTittle.AutoSize = true;
            this.label_diyetTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_diyetTittle.Location = new System.Drawing.Point(234, 79);
            this.label_diyetTittle.Name = "label_diyetTittle";
            this.label_diyetTittle.Size = new System.Drawing.Size(43, 15);
            this.label_diyetTittle.TabIndex = 7;
            this.label_diyetTittle.Text = "Diyet:";
            // 
            // label_hastalikValue
            // 
            this.label_hastalikValue.AutoSize = true;
            this.label_hastalikValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hastalikValue.Location = new System.Drawing.Point(132, 96);
            this.label_hastalikValue.Name = "label_hastalikValue";
            this.label_hastalikValue.Size = new System.Drawing.Size(36, 15);
            this.label_hastalikValue.TabIndex = 6;
            this.label_hastalikValue.Text = "Obez";
            // 
            // label_HastalikTittle
            // 
            this.label_HastalikTittle.AutoSize = true;
            this.label_HastalikTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_HastalikTittle.Location = new System.Drawing.Point(132, 79);
            this.label_HastalikTittle.Name = "label_HastalikTittle";
            this.label_HastalikTittle.Size = new System.Drawing.Size(63, 15);
            this.label_HastalikTittle.TabIndex = 5;
            this.label_HastalikTittle.Text = "Hastalık:";
            // 
            // label_hastaTcknoValue
            // 
            this.label_hastaTcknoValue.AutoSize = true;
            this.label_hastaTcknoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hastaTcknoValue.Location = new System.Drawing.Point(132, 61);
            this.label_hastaTcknoValue.Name = "label_hastaTcknoValue";
            this.label_hastaTcknoValue.Size = new System.Drawing.Size(84, 15);
            this.label_hastaTcknoValue.TabIndex = 4;
            this.label_hastaTcknoValue.Text = "48011047051";
            // 
            // label_hastaTcknoTittle
            // 
            this.label_hastaTcknoTittle.AutoSize = true;
            this.label_hastaTcknoTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hastaTcknoTittle.Location = new System.Drawing.Point(132, 44);
            this.label_hastaTcknoTittle.Name = "label_hastaTcknoTittle";
            this.label_hastaTcknoTittle.Size = new System.Drawing.Size(98, 15);
            this.label_hastaTcknoTittle.TabIndex = 3;
            this.label_hastaTcknoTittle.Text = "Hasta TCKNO:";
            // 
            // label_hastaAdiValue
            // 
            this.label_hastaAdiValue.AutoSize = true;
            this.label_hastaAdiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hastaAdiValue.Location = new System.Drawing.Point(132, 23);
            this.label_hastaAdiValue.Name = "label_hastaAdiValue";
            this.label_hastaAdiValue.Size = new System.Drawing.Size(191, 15);
            this.label_hastaAdiValue.TabIndex = 2;
            this.label_hastaAdiValue.Text = "Muzaffer Hamigil - (muzohamigil)";
            // 
            // label_hastaAdiTittle
            // 
            this.label_hastaAdiTittle.AutoSize = true;
            this.label_hastaAdiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hastaAdiTittle.Location = new System.Drawing.Point(132, 6);
            this.label_hastaAdiTittle.Name = "label_hastaAdiTittle";
            this.label_hastaAdiTittle.Size = new System.Drawing.Size(72, 15);
            this.label_hastaAdiTittle.TabIndex = 1;
            this.label_hastaAdiTittle.Text = "Hasta Adı:";
            // 
            // tabPage_hastaEkle
            // 
            this.tabPage_hastaEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_hastaEkle.Controls.Add(this.groupBox2);
            this.tabPage_hastaEkle.Location = new System.Drawing.Point(4, 27);
            this.tabPage_hastaEkle.Name = "tabPage_hastaEkle";
            this.tabPage_hastaEkle.Size = new System.Drawing.Size(437, 474);
            this.tabPage_hastaEkle.TabIndex = 2;
            this.tabPage_hastaEkle.Text = "Hasta Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox_diyet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_hastalik);
            this.groupBox2.Controls.Add(this.textBox_tckno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_soyad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button_hastaEkle);
            this.groupBox2.Controls.Add(this.textBox_parola);
            this.groupBox2.Controls.Add(this.label_parola);
            this.groupBox2.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox2.Controls.Add(this.label_kullaniciAdi);
            this.groupBox2.Location = new System.Drawing.Point(26, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 447);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(54, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Diyet:";
            // 
            // comboBox_diyet
            // 
            this.comboBox_diyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_diyet.FormattingEnabled = true;
            this.comboBox_diyet.Location = new System.Drawing.Point(57, 360);
            this.comboBox_diyet.Name = "comboBox_diyet";
            this.comboBox_diyet.Size = new System.Drawing.Size(237, 26);
            this.comboBox_diyet.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(54, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hastalık:";
            // 
            // comboBox_hastalik
            // 
            this.comboBox_hastalik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hastalik.FormattingEnabled = true;
            this.comboBox_hastalik.Location = new System.Drawing.Point(57, 306);
            this.comboBox_hastalik.Name = "comboBox_hastalik";
            this.comboBox_hastalik.Size = new System.Drawing.Size(237, 26);
            this.comboBox_hastalik.TabIndex = 6;
            // 
            // textBox_tckno
            // 
            this.textBox_tckno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_tckno.Location = new System.Drawing.Point(57, 255);
            this.textBox_tckno.Name = "textBox_tckno";
            this.textBox_tckno.Size = new System.Drawing.Size(237, 24);
            this.textBox_tckno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(54, 236);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(54, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Adı:";
            // 
            // button_hastaEkle
            // 
            this.button_hastaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hastaEkle.Location = new System.Drawing.Point(57, 398);
            this.button_hastaEkle.Name = "button_hastaEkle";
            this.button_hastaEkle.Size = new System.Drawing.Size(237, 35);
            this.button_hastaEkle.TabIndex = 8;
            this.button_hastaEkle.Text = "Sisteme Hasta Ekle";
            this.button_hastaEkle.UseVisualStyleBackColor = true;
            this.button_hastaEkle.Click += new System.EventHandler(this.button_hastaEkle_Click);
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
            // pictureBox_hastaResmi
            // 
            this.pictureBox_hastaResmi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_hastaResmi.Image = global::diyetisyenUygulamasi.Properties.Resources.siskoAdam;
            this.pictureBox_hastaResmi.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_hastaResmi.Name = "pictureBox_hastaResmi";
            this.pictureBox_hastaResmi.Size = new System.Drawing.Size(122, 122);
            this.pictureBox_hastaResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_hastaResmi.TabIndex = 0;
            this.pictureBox_hastaResmi.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_diyetisyen);
            this.panel2.Controls.Add(this.label_diyetisyenAdi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 53);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox_diyetisyen
            // 
            this.pictureBox_diyetisyen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_diyetisyen.Image = global::diyetisyenUygulamasi.Properties.Resources.diyetisyenAdam;
            this.pictureBox_diyetisyen.Location = new System.Drawing.Point(3, 5);
            this.pictureBox_diyetisyen.Name = "pictureBox_diyetisyen";
            this.pictureBox_diyetisyen.Size = new System.Drawing.Size(44, 42);
            this.pictureBox_diyetisyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_diyetisyen.TabIndex = 0;
            this.pictureBox_diyetisyen.TabStop = false;
            // 
            // label_diyetisyenAdi
            // 
            this.label_diyetisyenAdi.AutoSize = true;
            this.label_diyetisyenAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_diyetisyenAdi.Location = new System.Drawing.Point(53, 19);
            this.label_diyetisyenAdi.Name = "label_diyetisyenAdi";
            this.label_diyetisyenAdi.Size = new System.Drawing.Size(190, 20);
            this.label_diyetisyenAdi.TabIndex = 1;
            this.label_diyetisyenAdi.Text = "Emre Uzun - (emreuzun23)";
            // 
            // Form_DiyetisyenPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(461, 598);
            this.Name = "Form_DiyetisyenPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diyetisyen Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_DiyetisyenPenceresi_FormClosing);
            this.Load += new System.EventHandler(this.Form_DiyetisyenPenceresi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_hastalar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_hastaEkle.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hastaResmi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_diyetisyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_hastalar;
        private System.Windows.Forms.TabPage tabPage_hastaEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_diyetTittle;
        private System.Windows.Forms.Label label_hastalikValue;
        private System.Windows.Forms.Label label_HastalikTittle;
        private System.Windows.Forms.Label label_hastaTcknoValue;
        private System.Windows.Forms.Label label_hastaTcknoTittle;
        private System.Windows.Forms.Label label_hastaAdiValue;
        private System.Windows.Forms.Label label_hastaAdiTittle;
        private System.Windows.Forms.PictureBox pictureBox_hastaResmi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_tckno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_hastaEkle;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_hastalik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_diyet;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_diyetisyen;
        private System.Windows.Forms.Label label_diyetisyenAdi;
    }
}

