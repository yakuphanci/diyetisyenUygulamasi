using diyetisyenUygulamasi.DiyetDesignPattern;
using diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri;
using diyetisyenUygulamasi.HastalikDesignPattern;
using diyetisyenUygulamasi.HastalikDesignPattern.HastalikCesitleri;
using diyetisyenUygulamasi.RaporlamaDesignPattern;
using diyetisyenUygulamasi.RaporlamaDesignPattern.RaporFormatlari;
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
    public partial class Form_HastaGuncelleme : Form
    {
        Hasta hasta;
        bool bIslemYetki;
        public Form_HastaGuncelleme(Hasta _hasta, bool _islemYetki)
        {
            InitializeComponent(_islemYetki);
            this.bIslemYetki = _islemYetki;
            this.hasta = _hasta;
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

        RaporBilgi getRaporNesnesi()
        {
            RaporBilgi raporBilgi = new RaporBilgi();
            raporBilgi.ad = hasta.ad;
            raporBilgi.soyad = hasta.soyad;
            raporBilgi.tckno = hasta.tckno;
            raporBilgi.hastalikTuru = hasta.HastalikAdi();
            raporBilgi.diyetTuru = hasta.DiyetAdi();
            raporBilgi.diyetBilgi = hasta.DiyetBilgi();
            return raporBilgi;
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


        bool bHastalikDegisimi = false;
        private void button_hastalikDegis_Click(object sender, EventArgs e)
        {
            bHastalikDegisimi = !bHastalikDegisimi;
            comboBox_hastalik.Enabled = bHastalikDegisimi;
            if ( !bHastalikDegisimi )
                hasta.HastalikDegis(selectedHastalik());

            if (bHastalikDegisimi)
                button_hastalikDegis.Text = "Kaydet";
            else
                button_hastalikDegis.Text = "Değiştir";
        }

        bool bDiyetDegisimi = false;
        private void button_diyetDegis_Click(object sender, EventArgs e)
        {
            bDiyetDegisimi = !bDiyetDegisimi;
            comboBox_diyet.Enabled = bDiyetDegisimi;
            if (!bDiyetDegisimi)
                hasta.DiyetDegis(selectedDiyet());

            if (bDiyetDegisimi)
                button_diyetDegis.Text = "Kaydet";
            else
                button_diyetDegis.Text = "Değiştir";
        }

        private void comboBox_diyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diyet = comboBox_diyet.SelectedItem.ToString();
            if (diyet == "Akdeniz")
                richTextBox_diyetBilgi.Text =  new Akdeniz().DiyetBilgi();
            else if (diyet == "Gluten Free")
                richTextBox_diyetBilgi.Text = new GlutenFree().DiyetBilgi();
            else if (diyet == "Deniz Ürünleri")
                richTextBox_diyetBilgi.Text = new DenizUrunleri().DiyetBilgi();
            else
                richTextBox_diyetBilgi.Text = new YesilliklerDunyasi().DiyetBilgi();
        }

        private void button_raporla_Click(object sender, EventArgs e)
        {
            RaporBilgi raporBilgi = this.getRaporNesnesi();
            RaporAbstraction rapor = new RefinedRaporAbstraction();
            
            if(radioButton_raporTypeHTML.Checked)
                rapor._raporOlusturucu = new HtmlRaporOlusturucu(raporBilgi);
            else
                rapor._raporOlusturucu = new JsonRaporOlusturucu(raporBilgi);

            if (radioButton_raporDuzenHD.Checked)
                rapor.RaporOlustur();
            else
                rapor.RaporOlusturTers();
        }

        #region Load - Close
        private void Form_HastaGuncelleme_Load(object sender, EventArgs e)
        {
            textBox_ad.Text = hasta.ad;
            textBox_soyad.Text = hasta.soyad;
            textBox_tckno.Text = hasta.tckno;
            textBox_kullaniciAdi.Text = hasta.kullaniciAdi;

            //comboBox doldurma.
            HastalikDoldur();

            comboBox_hastalik.SelectedItem = hasta.HastalikAdi();

            //comboBox doldurma.
            DiyetDoldur();

            comboBox_diyet.SelectedItem = hasta.DiyetAdi();

            richTextBox_diyetBilgi.Text = hasta.DiyetBilgi();

        }

        private void Form_HastaGuncelleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bIslemYetki)
                Program.form_Giris.Show();
        }
        #endregion
    }
}
