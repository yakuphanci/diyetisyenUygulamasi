using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri
{
    public class Akdeniz : IDiyet
    {
        public string DiyetAdi()
        {
            return "Akdeniz";
        }

        public string DiyetBilgi()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Pazartesi");
            sb.AppendLine("Kahvaltı: 1 adet yumurta +1 dilim az yağlı beyaz peynir + kepekli ekmek + domates, salatalık");
            sb.AppendLine("Öğlen: Ton balıklı bol yeşillikli salata + 1 dilim kepekli ekmek"                            );
            sb.AppendLine("Ara: Yarım yağlı süt + Badem"                                                                );
            sb.AppendLine("Akşam: Zeytinyağlı sebze yemeği + yarım yağlı yoğurt +salata"                                );
            sb.AppendLine("Ara öğün: Meyve"                                                                             );
            sb.AppendLine(                                                                                              );
            sb.AppendLine("Salı"                                                                                        );
            sb.AppendLine("Kahvaltı: 2 dilim beyaz peynir + Zeytin + Kepek ekmeği + Domates, salatalık, yeşillik"       );
            sb.AppendLine("Öğlen: Fırında ızgara sebze + Makarna + Ayran"                                               );
            sb.AppendLine("Ara: Meyve + fındık"                                                                         );
            sb.AppendLine("Akşam: Zeytinyağlı bakliyat yemeği + yarım yağlı yoğurt +salata"                             );
            sb.AppendLine("Ara: Yarım yağlı süt + meyve"                                                                );
            sb.AppendLine(                                                                                              );
            sb.AppendLine("Çarşamba"                                                                                    );
            sb.AppendLine("Kahvaltı: Yarım yağlı yoğurt + 3 kaşık yulaf ezmesi + meyve"                                 );
            sb.AppendLine("Öğlen: Peynirli, avokadolu salata +kepekli ekmek + ayran"                                    );
            sb.AppendLine("Ara: Yarım yağlı süt + ceviz"                                                                );
            sb.AppendLine("Akşam: Izgara balık +bol yeşillikli salata"                                                  );
            sb.AppendLine("Ara: Meyve"                                                                                  );
            sb.AppendLine(                                                                                              );
            sb.AppendLine("Perşembe"                                                                                    );
            sb.AppendLine("Kahvaltı: Peynirli omlet +zeytin + kepek ekmeği + Yeşillik"                                  );
            sb.AppendLine("Öğlen: Zeytinyağlı bakliyat yemeği + Yarım yağlı yoğurt +Salata"                             );
            sb.AppendLine("Ara: Meyve + badem"                                                                          );
            sb.AppendLine("Akşam: Zeytinyağlı sebze yemeği + Bulgur pilavı + Ayran"                                     );
            sb.AppendLine("Ara: Yarım yağlı yoğurt + ceviz"                                                             );
            sb.AppendLine(                                                                                              );
            sb.AppendLine("Cuma"                                                                                        );
            sb.AppendLine("Kahvaltı: Lor peyniri +Ceviz + Kepek ekmeği + Domates, salatalık"                            );
            sb.AppendLine("Öğlen: Haşlanmış mercimekli salata + ayran"                                                  );
            sb.AppendLine("Ara: 1 kase yoğurt +Meyve"                                                                   );
            sb.AppendLine("Akşam: Zeytinyağlı sebze yemeği + salata + kepek ekmeği"                                     );
            sb.AppendLine("Ara: Meyve"                                                                                  );
            sb.AppendLine(                                                                                              );
            sb.AppendLine("Cumartesi"                                                                                   );
            sb.AppendLine("Kahvaltı: Yarım yağlı süt + Fındık + 2 yemek kaşığı yulaf ezmesi + Meyve"                    );
            sb.AppendLine("Öğlen: Sebzeli makarna +ayran + salata"                                                      );
            sb.AppendLine("Ara: Meyve + ceviz"                                                                          );
            sb.AppendLine("Akşam: Izgara Tavuk +Yarım yağlı yoğurt + Haşlama sebze"                                     );
            sb.AppendLine("Ara: Yarım yağlı süt + meyve"                                                                );
            sb.AppendLine(                                                                                              );
            sb.AppendLine("Pazar"                                                                                       );
            sb.AppendLine("Kahvaltı: Menemen + Yarım yağlı beyaz peynir + Kepek ekmeği + yeşillik"                      );
            sb.AppendLine("Öğlen: Tam tahıl ekmeğine yapılmış sandviç + ayran"                                          );
            sb.AppendLine("Ara: Meyve + badem"                                                                          );
            sb.AppendLine("Akşam: Çorba + Zeytinyağlı bakliyat yemeği + Salata"                                         );
            sb.AppendLine("Ara: Yarım yağlı süt"                                                                        );


            
            return sb.ToString();
        }
    }
}
