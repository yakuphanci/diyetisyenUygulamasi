using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diyetisyenUygulamasi.DiyetDesignPattern;
using diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri;
using diyetisyenUygulamasi.HastalikDesignPattern;
using diyetisyenUygulamasi.HastalikDesignPattern.HastalikCesitleri;
using diyetisyenUygulamasi.RaporlamaDesignPattern;
using diyetisyenUygulamasi.RaporlamaDesignPattern.RaporFormatlari;

namespace diyetisyenUygulamasi
{
    
   

   
    public partial class Form_DiyetisyenPenceresi : Form
    {
        Diyetisyen diyetisyen;
        public Form_DiyetisyenPenceresi(Diyetisyen _diyetisyen)
        {
            InitializeComponent();
            this.diyetisyen = _diyetisyen;
        }

        private Panel getHastaPanel(Hasta hasta)
        {
            // 
            // panel_container
            // 

            Panel container = new Panel();
            container.BackColor = System.Drawing.SystemColors.ControlLight;
            container.Cursor = System.Windows.Forms.Cursors.Hand;
            container.Location = new System.Drawing.Point(3, 3);
            container.Size = new System.Drawing.Size(383, 128);
            container.Tag = hasta.kullaniciAdi;
            container.Click += new EventHandler(HastaPanel_Click);
            // 
            // label_diyetValue
            // 
            Label label_diyetValue = new Label();
            label_diyetValue.AutoSize = true;
            label_diyetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_diyetValue.Location = new System.Drawing.Point(234, 96);
            label_diyetValue.Size = new System.Drawing.Size(106, 15);
            label_diyetValue.Text = hasta.DiyetAdi();
            // 
            // label_diyetTittle
            // 
            Label label_diyetTittle = new Label();
            label_diyetTittle.AutoSize = true;
            label_diyetTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_diyetTittle.Location = new System.Drawing.Point(234, 79);
            label_diyetTittle.Size = new System.Drawing.Size(43, 15);
            label_diyetTittle.Text = "Diyet:";
            // 
            // label_hastalikValue
            // 
            Label label_hastalikValue = new Label();
            label_hastalikValue.AutoSize = true;
            label_hastalikValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_hastalikValue.Location = new System.Drawing.Point(132, 96);
            label_hastalikValue.Size = new System.Drawing.Size(36, 15);
            label_hastalikValue.Text = hasta.HastalikAdi();
            // 
            // label_HastalikTittle
            // 
            Label label_hastalikTittle = new Label();
            label_hastalikTittle.AutoSize = true;
            label_hastalikTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_hastalikTittle.Location = new System.Drawing.Point(132, 79);
            label_hastalikTittle.Size = new System.Drawing.Size(63, 15);
            label_hastalikTittle.Text = "Hastalık:";
            // 
            // label_hastaTcknoValue
            // 
            Label label_hastaTcknoValue = new Label();
            label_hastaTcknoValue.AutoSize = true;
            label_hastaTcknoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_hastaTcknoValue.Location = new System.Drawing.Point(132, 61);
            label_hastaTcknoValue.Size = new System.Drawing.Size(84, 15);
            label_hastaTcknoValue.Text = hasta.tckno;
            // 
            // label_hastaTcknoTittle
            // 
            Label label_hastaTcknoTittle = new Label();
            label_hastaTcknoTittle.AutoSize = true;
            label_hastaTcknoTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_hastaTcknoTittle.Location = new System.Drawing.Point(132, 44);
            label_hastaTcknoTittle.Size = new System.Drawing.Size(98, 15);
            label_hastaTcknoTittle.Text = "Hasta TCKNO:";
            // 
            // label_hastaAdiValue
            // 
            Label label_hastaAdiValue = new Label();
            label_hastaAdiValue.AutoSize = true;
            label_hastaAdiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_hastaAdiValue.Location = new System.Drawing.Point(132, 23);
            label_hastaAdiValue.Size = new System.Drawing.Size(191, 15);
            label_hastaAdiValue.Text = hasta.ad + " " + hasta.soyad + " - (" + hasta.kullaniciAdi + ")";
            // 
            // label_hastaAdiTittle
            // 
            Label label_hastaAdiTittle = new Label();
            label_hastaAdiTittle.AutoSize = true;
            label_hastaAdiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label_hastaAdiTittle.Location = new System.Drawing.Point(132, 6);
            label_hastaAdiTittle.Size = new System.Drawing.Size(72, 15);
            label_hastaAdiTittle.Text = "Hasta Adı:";
            // 
            // pictureBox_hastaResmi
            // 
            PictureBox pictureBox_hastaResmi = new PictureBox();
            Random r = new Random();
            pictureBox_hastaResmi.BackColor = Color.FromArgb(r.Next(55, 111), r.Next(55, 111), r.Next(55, 111));
            pictureBox_hastaResmi.Image = global::diyetisyenUygulamasi.Properties.Resources.siskoAdam;
            pictureBox_hastaResmi.Location = new System.Drawing.Point(3, 3);
            pictureBox_hastaResmi.Size = new System.Drawing.Size(122, 122);
            pictureBox_hastaResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_hastaResmi.TabStop = false;

            container.Controls.Add(pictureBox_hastaResmi);
            container.Controls.Add(label_diyetValue);
            container.Controls.Add(label_diyetTittle);
            container.Controls.Add(label_hastalikValue);
            container.Controls.Add(label_hastalikTittle);
            container.Controls.Add(label_hastaTcknoValue);
            container.Controls.Add(label_hastaTcknoTittle);
            container.Controls.Add(label_hastaAdiValue);
            container.Controls.Add(label_hastaAdiTittle);
            container.Controls.Add(pictureBox_hastaResmi);
            return container;
            }

        private void HastaPanel_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = ((Panel)(sender)).Tag.ToString();
            Hasta tiklananHasta = Veriler.getHasta(kullaniciAdi);
            Form_HastaGuncelleme frm_hastaBilgi = new Form_HastaGuncelleme(tiklananHasta, true);
            frm_hastaBilgi.ShowDialog();
        }

        private IHastalik selectedHastalik()
        {
            string hastalik = comboBox_hastalik.SelectedItem.ToString();
            if (hastalik == "Obez")
                return new Obez();
            else if (hastalik == "Şeker")
                return new Seker();
            else
                return new Colyak();
        }

        private IDiyet selectedDiyet()
        {
            string diyet = comboBox_diyet.SelectedItem.ToString();
            if (diyet == "Akdeniz")
                return new Akdeniz();
            else if (diyet == "Gluten Free")
                return new GlutenFree();
            else if (diyet == "Deniz Ürünleri")
                return new DenizUrunleri();
            else
                return new YesilliklerDunyasi();
        }

        private bool dolulukKontrol()
        {
            bool hepsiDoluMu = false;
            hepsiDoluMu = textBox_ad.Text != ""
                && textBox_soyad.Text != ""
                && textBox_tckno.Text != ""
                && textBox_kullaniciAdi.Text != ""
                && textBox_parola.Text != ""
                && comboBox_diyet.SelectedIndex > -1
                && comboBox_hastalik.SelectedIndex > -1;

            return hepsiDoluMu;
        }

        private void bosaltKayitEkrani()
        {
            textBox_ad.Text = "";
            textBox_soyad.Text = "";
            textBox_tckno.Text = "";
            textBox_kullaniciAdi.Text = "";
            textBox_parola.Text = "";
            comboBox_diyet.SelectedIndex = -1;
            comboBox_hastalik.SelectedIndex = -1;


        }

        private void listeleHastalar()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var hasta in diyetisyen.hastalar)
            {
                flowLayoutPanel1.Controls.Add(getHastaPanel(hasta));
            }
        }

        private void diyetisyenBilgiDoldur()
        {
            label_diyetisyenAdi.Text = diyetisyen.ad + " " + diyetisyen.soyad + " - (" + diyetisyen.kullaniciAdi + ")";
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            listeleHastalar();
        }

    
        private void button_hastaEkle_Click(object sender, EventArgs e)
        {
            if (dolulukKontrol())
            {
                string _kullaniciAdi = textBox_kullaniciAdi.Text;
                string _parola = textBox_parola.Text;
                string _ad = textBox_ad.Text;
                string _soyad = textBox_soyad.Text;
                string _tckno = textBox_tckno.Text;

                Hasta hasta = new Hasta(_kullaniciAdi, _parola, selectedHastalik())
                {
                    ad = _ad,
                    soyad = _soyad,
                    tckno = _tckno
                };
                hasta.DiyetDegis(selectedDiyet());

                bool eklendiMi = this.diyetisyen.HastaEkle(hasta);
                if (eklendiMi)
                {
                    MessageBox.Show("Hasta sisteme başarılı bir şekilde eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bosaltKayitEkrani();
                }
                else
                    MessageBox.Show("Sisteme hasta eklenmedi. Hastaya atadığınız kullanıcı adını benzersiz seçiniz lütfen.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        #region comboBox-doldurma
        private void HastalikDoldur()
        {
            comboBox_hastalik.Items.Add("Obez");
            comboBox_hastalik.Items.Add("Şeker");
            comboBox_hastalik.Items.Add("Çölyak");
        }
        
        private void DiyetDoldur()
        {
            comboBox_diyet.Items.Add("Akdeniz");
            comboBox_diyet.Items.Add("Yeşillikler Dünyası");
            comboBox_diyet.Items.Add("Gluten Free");
            comboBox_diyet.Items.Add("Deniz Ürünleri");
        }
        #endregion

        #region Load - Close 
        private void Form_DiyetisyenPenceresi_Load(object sender, EventArgs e)
        {
            HastalikDoldur();
            DiyetDoldur();
            listeleHastalar();
            diyetisyenBilgiDoldur();

        }

        private void Form_DiyetisyenPenceresi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form_Giris.Show();
        }

        #endregion

      
    }
}
