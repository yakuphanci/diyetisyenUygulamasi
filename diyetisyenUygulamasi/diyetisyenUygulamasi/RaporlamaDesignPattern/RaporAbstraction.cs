using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.RaporlamaDesignPattern
{
    public abstract class RaporAbstraction
    {
        public RaporImplementor _raporOlusturucu;
        public abstract void RaporOlustur();
        public abstract void RaporOlusturTers();
    }
}
