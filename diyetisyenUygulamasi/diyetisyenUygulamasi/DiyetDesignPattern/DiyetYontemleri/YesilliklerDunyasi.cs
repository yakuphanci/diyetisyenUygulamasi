using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri
{
    public class YesilliklerDunyasi : IDiyet
    {
        public string DiyetAdi()
        {
            return "Yeşillikler Dünyası";
        }

        public string DiyetBilgi()
        {
            StringBuilder sb = new StringBuilder();

           sb.AppendLine("YEŞİLLİKLER DÜNYASI DİYETİ   ");
           sb.AppendLine("                             ");
           sb.AppendLine(" Kahvaltı:                   ");
           sb.AppendLine("1 dilim diyet ekmeği,        ");
           sb.AppendLine("2 - 3 dilim domates,         ");
           sb.AppendLine("2 - 3 dilim salatalık,       ");
           sb.AppendLine("  Şekersiz çay,              ");
           sb.AppendLine("Maydanoz,                    ");
           sb.AppendLine("Marul,                       ");
           sb.AppendLine("                             ");
           sb.AppendLine("Ara öğün:                    ");
           sb.AppendLine("2 tane kayısı,               ");
           sb.AppendLine("1 tane elma.                 ");
           sb.AppendLine("                             ");
           sb.AppendLine("Öğlen yemeği:                ");
           sb.AppendLine("Yeşillikli salata,           ");
           sb.AppendLine(" 1 dilim diyet ekmeği,       ");
           sb.AppendLine("1 kase çorba,                ");
           sb.AppendLine("150 gram diyet yoğurt.       ");
           sb.AppendLine("                             ");
           sb.AppendLine("Ara öğün:                    ");
           sb.AppendLine("2 tane erik.                 ");
           sb.AppendLine("                             ");
           sb.AppendLine("Akşam yemeği:                ");
           sb.AppendLine("1 dilim diyet ekmeği,        ");
           sb.AppendLine("1 kase çorba,                ");
           sb.AppendLine("Yeşillikli salata,           ");
           sb.AppendLine("200 gram diyet yoğurt.       ");
           sb.AppendLine("                             ");
           sb.AppendLine("Ara öğün:                    ");
           sb.AppendLine("1 tane armut.                ");



            return sb.ToString();
        }
    }
}
