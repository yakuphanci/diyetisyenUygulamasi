using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.HastalikDesignPattern.HastalikCesitleri
{
    public class Colyak : IHastalik
    {
        public string HastalikAdi()
        {
            return "Çölyak";
        }
    }
}
