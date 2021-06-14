using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri
{
    public class GlutenFree : IDiyet
    {
        public string DiyetAdi()
        {
            return "Gluten Free";
        }

        public string DiyetBilgi()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Glutensiz Diyet Listesi –  Menü                                                               ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Pazartesi                                                                                     ");
            sb.AppendLine("Kahvaltı: Glutensiz ekmek, çiğ sebze(buharda yapılabilir), beyaz peynir, 2 tane kuru erik.    ");
            sb.AppendLine("Öğle: Izgara balık, rokalı salata, mısır ekmeği.                                              ");
            sb.AppendLine("Akşam: Tavuk sote, pirinçli yayla çorbası, mevsim salatası.                                   ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Salı                                                                                          ");
            sb.AppendLine("Kahvaltı: Glutensiz kahvaltılık gevrek, 2 ceviz, 10 adet yaban mersini, yarım yağlı süt.      ");
            sb.AppendLine("Öğle: Unsuz mantarlı omlet, glutensiz ekmek, domates, salatalık.                              ");
            sb.AppendLine("Akşam: Zeytinyağlı pırasa, mısır ekmeği, yoğurt.                                              ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Çarşamba                                                                                      ");
            sb.AppendLine("Kahvaltı: Glutensiz ekmek, 2 ceviz, yarım yağlı peynir, çiğ sebze.                            ");
            sb.AppendLine("Öğle: Çoban salatası, zeytinyağlı kuru fasulye, glutensiz ekmek.                              ");
            sb.AppendLine("Akşam: Fırında balık, pirinçli ezogelin çorba, yeşil salata.                                  ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Perşembe                                                                                      ");
            sb.AppendLine("Kahvaltı: Maydanozlu lor peyniri, zeytin, çiğ sebze, glutensiz ekmek.                         ");
            sb.AppendLine("Öğle: Yeşillik salatası, köfte (malzemesi ekmeksiz), pirinç pilavı.                           ");
            sb.AppendLine("Akşam: Haşlama sebze, kıymalı mercimek yemeği, glutensiz ekmek.                               ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Cuma                                                                                          ");
            sb.AppendLine("Kahvaltı: Taze sebze, mısır ekmeği, yarım yağlı kaşar, 1 kaşık reçel.                         ");
            sb.AppendLine("Öğle: Sebzeli fırında hindi, unsuz mercimek çorbası, mevsim salatası.                         ");
            sb.AppendLine("Akşam: Ispanak yemeği, dereotlu cacık, glutensiz ekmek.                                       ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Cumartesi                                                                                     ");
            sb.AppendLine("Kahvaltı: 1 elma, mısır ekmeği, taze sebze, 1 yumurta.                                        ");
            sb.AppendLine("Öğle: Zeytinyağlı kabak, domates çorbası, yoğurt, domates, salatalık.                         ");
            sb.AppendLine("Akşam: Tavuklu sebze sote, ayran.                                                             ");
            sb.AppendLine("                                                                                              ");
            sb.AppendLine("Pazar                                                                                         ");
            sb.AppendLine("Kahvaltı: Peynirli omlet, taze sebze, 2 ceviz.                                                ");
            sb.AppendLine("Öğle: Bonfile ızgara, közlenmiş kırmızıbiber, mısır ekmeği                                    ");
            sb.AppendLine("Akşam: Ton balıklı salata, domates çorbası, 2 ceviz.                                          ");

            return sb.ToString();
        }
    }
}
