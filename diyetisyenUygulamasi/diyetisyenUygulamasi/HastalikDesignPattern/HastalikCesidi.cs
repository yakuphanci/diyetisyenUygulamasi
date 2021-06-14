using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.HastalikDesignPattern
{
    public class HastalikCesidi
    {
        private IHastalik hastalikCesidi;
        public HastalikCesidi(IHastalik _hastalikCesidi)
        {
            this.hastalikCesidi = _hastalikCesidi;
        }

        public string HastalikAdi()
        {
            return this.hastalikCesidi.HastalikAdi();
        }
    }
}
