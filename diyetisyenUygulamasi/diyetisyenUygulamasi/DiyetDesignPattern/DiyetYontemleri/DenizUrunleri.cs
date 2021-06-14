using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri
{
    public class DenizUrunleri : IDiyet
    {
        public string DiyetAdi()
        {
            return "Deniz Ürünleri";
        }

        public string DiyetBilgi()
        {
            StringBuilder sb = new StringBuilder();

              sb.AppendLine("SABAH:                                            ");
              sb.AppendLine("> Kahvaltı öncesi 2 bardak su.                    ");
              sb.AppendLine("> 1 adet haşlanmış yumurta                        ");
              sb.AppendLine("> 2 yemek kaşığı lor peyniri                      ");
              sb.AppendLine("> 1 adet tam ceviz                                ");
              sb.AppendLine("> 1 ince dilim tam buğday ekmeği(25 gr)           ");
              sb.AppendLine("> Kırmızı biber, 7 - 8 sap maydanoz               ");
              sb.AppendLine("> 1 kupa yeşil çay                                ");
              sb.AppendLine("                                                  ");
              sb.AppendLine("ÖĞLE :                                            ");
              sb.AppendLine("> Öğle yemeği öncesi 2 bardak su                  ");
              sb.AppendLine("> Somon balığı(200 gr)                            ");
              sb.AppendLine("> Roka salatası                                   ");
              sb.AppendLine("> 1 Kepçe mercimek çorbası                        ");
              sb.AppendLine("                                                  ");
              sb.AppendLine("İKİNDİ:                                           ");
              sb.AppendLine("> İkindi öncesi 2 bardak su                       ");
              sb.AppendLine("> 1 avuç kabuklu fındık                           ");
              sb.AppendLine("> 2 adet kuru kayısı veya kuru incir              ");
              sb.AppendLine("                                                  ");
              sb.AppendLine("AKŞAM:                                            ");
              sb.AppendLine("> Akşam yemeği öncesi 2 bardak su                 ");
              sb.AppendLine("> 1 kase maydanozlu-dereotlu - soğanlı salata     ");
              sb.AppendLine("> 6 - 8 kaşık haşlanmış börülce                   ");
              sb.AppendLine("> 1 su bardağı  ayran(200 ml)                     ");
    


            return sb.ToString();
        }
    }
}
