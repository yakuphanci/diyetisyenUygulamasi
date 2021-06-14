using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri;
using diyetisyenUygulamasi.HastalikDesignPattern;
using diyetisyenUygulamasi.HastalikDesignPattern.HastalikCesitleri;

namespace diyetisyenUygulamasi
{
    public class Diyetisyen : Kullanici
    {
        public List<Hasta> hastalar;
        public Diyetisyen(string kullaniciAdi, string parola) : base(kullaniciAdi, parola) 
        {
            hastalar = Veriler.getHastalar(this.kullaniciAdi);
        }

        public bool HastaEkle(Hasta hasta)
        {
            bool eklendiMi = false;


            hasta.diyetisyenAdi = this.kullaniciAdi;
            eklendiMi = Veriler.EkleHasta(hasta);
            //Eger verilere hasta eklendiyse, yereldeki listeye de ekle.
            if (eklendiMi)
                this.hastalar.Add(hasta);

            return eklendiMi;
        }
    }
}
