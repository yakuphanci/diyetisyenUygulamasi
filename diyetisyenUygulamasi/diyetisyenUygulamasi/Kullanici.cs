using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi
{
    public abstract class Kullanici
    {
        public string kullaniciAdi { get; protected set; }
        protected string parola = null;

        public string ad = null;
        public string soyad = null;
        public string tckno = null;

        public Kullanici(string _kullaniciAdi, string _parola)
        {
            this.kullaniciAdi = _kullaniciAdi;
            this.parola = _parola;
        }

        public virtual bool GirisYap(string _parola)
        {
            bool sonuc = this.parola == _parola;
            return sonuc;
        }
    }
}
