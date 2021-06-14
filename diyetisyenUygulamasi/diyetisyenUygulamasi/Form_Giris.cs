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
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
            Veriler.testVerileriIleDoldur();
        }

        private void button_adminGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox_kullaniciAdi.Text;
            string parola = textBox_parola.Text;

            Admin valid_admin = Veriler.getAdmin(kullaniciAdi);
            if (valid_admin != null)
            {
                bool valid_parola = valid_admin.GirisYap(parola);
                if (valid_parola)
                {
                    Form_AdminPenceresi frm_admin = new Form_AdminPenceresi(valid_admin);
                    this.Hide();
                    frm_admin.ShowDialog();

                }
                else
                    MessageBox.Show("Parolanız geçersiz. Lütfen biraz düşünün ve tekrar deneyin.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Kullanıcı adı geçersiz. Lütfen biraz düşünün ve tekrar deneyin.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
            
        private void button_diyetisyenGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox_kullaniciAdi.Text;
            string parola = textBox_parola.Text;

            Diyetisyen valid_diyetisyen = Veriler.getDiyetisyen(kullaniciAdi);
            if (valid_diyetisyen != null)
            {
                bool valid_parola = valid_diyetisyen.GirisYap(parola);
                if (valid_parola)
                {
                    Form_DiyetisyenPenceresi frm_diyetisyen = new Form_DiyetisyenPenceresi(valid_diyetisyen);
                    this.Hide();
                    frm_diyetisyen.ShowDialog();

                }
                else
                    MessageBox.Show("Parolanız geçersiz. Lütfen biraz düşünün ve tekrar deneyin.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Kullanıcı adı geçersiz. Lütfen biraz düşünün ve tekrar deneyin.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button_hastaGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox_kullaniciAdi.Text;
            string parola = textBox_parola.Text;

            Hasta valid_hasta = Veriler.getHasta(kullaniciAdi);
            if (valid_hasta != null)
            {
                bool valid_parola = valid_hasta.GirisYap(parola);
                if (valid_parola)
                {
                    Form_HastaGuncelleme frm_hasta = new Form_HastaGuncelleme(valid_hasta, false);
                    this.Hide();
                    frm_hasta.ShowDialog();

                }
                else
                    MessageBox.Show("Parolanız geçersiz. Lütfen biraz düşünün ve tekrar deneyin.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Kullanıcı adı geçersiz. Lütfen biraz düşünün ve tekrar deneyin.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
