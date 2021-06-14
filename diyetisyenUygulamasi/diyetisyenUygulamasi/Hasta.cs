using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using diyetisyenUygulamasi.HastalikDesignPattern;
using diyetisyenUygulamasi.DiyetDesignPattern;
using diyetisyenUygulamasi.RaporlamaDesignPattern;
using diyetisyenUygulamasi.RaporlamaDesignPattern.RaporFormatlari;

namespace diyetisyenUygulamasi
{
    public class Hasta : Kullanici
    {

        private HastalikCesidi hastalik;
        private DiyetYontem diyet;
        public string diyetisyenAdi;
        
        public Hasta(string _kullaniciAdi, string _parola, IHastalik _hastalik) : base(_kullaniciAdi, _parola) 
        {
            this.HastalikDegis(_hastalik);
        }

        public void HastalikDegis(IHastalik _hastalik)
        {
            this.hastalik = new HastalikCesidi(_hastalik);
        }

        public string HastalikAdi()
        {
            return this.hastalik.HastalikAdi();
        }
        
        public void DiyetDegis(IDiyet _diyet)
        {
            this.diyet = new DiyetYontem(_diyet);
        }

        public string DiyetBilgi()
        {
            if (diyet != null)
                return this.diyet.DiyetBilgi();
            else
                return "Hasta'da tanımlı bir diyet yöntemi yok.";
        }

        public string DiyetAdi()
        {
          
            if (diyet != null)
                return this.diyet.DiyetAdi();
            else
                return "Diyet Tanımlanmadı.";
        }


       
        public void Raporla(RaporImplementor _raporOlusturucu)
        {
            RaporAbstraction raporOlusturucu = new RefinedRaporAbstraction();
            raporOlusturucu._raporOlusturucu = _raporOlusturucu;
            raporOlusturucu.RaporOlustur();
        }

        public void RaporlaTers(RaporImplementor _raporOlusturucu)
        {
            RaporAbstraction raporOlusturucu = new RefinedRaporAbstraction();
            raporOlusturucu._raporOlusturucu = _raporOlusturucu;
            raporOlusturucu.RaporOlusturTers();
        }
    }
}
