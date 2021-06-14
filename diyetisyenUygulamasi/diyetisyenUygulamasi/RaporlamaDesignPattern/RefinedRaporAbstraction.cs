using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.RaporlamaDesignPattern
{
    public class RefinedRaporAbstraction : RaporAbstraction
    {
      
        public override void RaporOlustur()
        {
            this._raporOlusturucu.RaporOlustur();
        }

        public override void RaporOlusturTers()
        {
            this._raporOlusturucu.RaporOlusturTers();
        }
    }
}
