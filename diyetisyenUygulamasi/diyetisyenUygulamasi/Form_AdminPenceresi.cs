using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenUygulamasi
{
    public partial class Form_AdminPenceresi : Form
    {
        Admin admin;
        public Form_AdminPenceresi(Admin _admin)
        {
            InitializeComponent();
            admin = _admin;
        }


        //Diyetisyen listesini yeniler.
        private void button_yenile_Click(object sender, EventArgs e)
        {
            listBox_diyetisyenler.Items.Clear();
            #region Diyetisyenleri Listele
            foreach (var diyetisyen in Veriler.diyetisyenler)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("("+diyetisyen.kullaniciAdi + ") - ");
                sb.Append(diyetisyen.ad + " " + diyetisyen.soyad + " - "  + diyetisyen.tckno);
                listBox_diyetisyenler.Items.Add(sb.ToString());
            }
            #endregion
        }


        private bool dolulukKontrol()
        {
            bool hepsiDoluMu = false;
            hepsiDoluMu = textBox_ad.Text != "" && textBox_soyad.Text != "" && textBox_tckno.Text != "" && textBox_kullaniciAdi.Text != "" && textBox_parola.Text != "";
            return hepsiDoluMu;
        }

        private void button_diyetisyenEkle_Click(object sender, EventArgs e)
        {
            if (dolulukKontrol())
            {
                string _kullaniciAdi = textBox_kullaniciAdi.Text;
                string _parola = textBox_parola.Text;
                string _ad = textBox_ad.Text;
                string _soyad = textBox_soyad.Text;
                string _tckno = textBox_tckno.Text;

                bool eklendiMi = admin.DiyetisyenEkle(_kullaniciAdi, _parola, _tckno, _ad, _soyad);
                if (eklendiMi)
                    MessageBox.Show("Diyetisyen sisteme başarılı bir şekilde eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme diyetisyen eklenmedi. Diyetisyene atadığınız kullanıcı adını benzersiz seçiniz lütfen.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        #region Load - Close Olayları
        private void Form_AdminPenceresi_Load(object sender, EventArgs e)
        {
            button_yenile.PerformClick();
        }
        private void Form_AdminPenceresi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form_Giris.Show();
        }
        #endregion

    }
}
