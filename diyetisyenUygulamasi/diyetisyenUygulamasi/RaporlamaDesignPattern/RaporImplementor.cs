using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.RaporlamaDesignPattern
{
    public abstract class RaporImplementor
    {
        protected RaporBilgi raporBilgi;
        public RaporImplementor(RaporBilgi _raporBilgi)
        {
            this.raporBilgi = _raporBilgi;
        }

        public abstract void RaporOlustur();
        public abstract void RaporOlusturTers();
    }
}
