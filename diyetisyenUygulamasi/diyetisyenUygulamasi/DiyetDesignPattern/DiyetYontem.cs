using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.DiyetDesignPattern
{
    public class DiyetYontem
    {
        private IDiyet diyetYontemi;
        public DiyetYontem(IDiyet _diyetYontemi)
        {
            this.diyetYontemi = _diyetYontemi;
        }

        public string DiyetBilgi()
        {
            return this.diyetYontemi.DiyetBilgi();
        }
        public string DiyetAdi()
        {
            return this.diyetYontemi.DiyetAdi();
        }
    }
}
