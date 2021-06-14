using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi
{
    public class Admin : Kullanici
    {
        public Admin(string _kullaniciAdi, string _parola) : base(_kullaniciAdi, _parola) { }

     

        public bool DiyetisyenEkle(string _kullaniciAdi, string _parola, string _tckno, string _ad, string _soyad)
        {
            bool eklendiMi = false;

            Diyetisyen diyetisyen = new Diyetisyen(_kullaniciAdi, _parola)
            {
                tckno = _tckno,
                ad = _ad,
                soyad = _soyad
            };

            eklendiMi = Veriler.EkleDiyetisyen(diyetisyen);

            return eklendiMi;
        }
    }
}
