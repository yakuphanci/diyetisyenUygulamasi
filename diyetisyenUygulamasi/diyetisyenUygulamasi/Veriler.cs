using diyetisyenUygulamasi.DiyetDesignPattern.DiyetYontemleri;
using diyetisyenUygulamasi.HastalikDesignPattern.HastalikCesitleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi
{
    public static class Veriler
    {
        public static List<Admin> adminler = new List<Admin>() { new Admin("admin", "123") { ad = "Admin", soyad = "Adminoglu", tckno = "00000000000" } };
        public static List<Diyetisyen> diyetisyenler = new List<Diyetisyen>();
        public static List<Hasta> hastalar = new List<Hasta>();

        
        public static void testVerileriIleDoldur()
        {
            var hasta = new Hasta("0906202101", "123", new Seker()) { ad = "Çetin", soyad = "Hınzır", tckno = "29637485231", diyetisyenAdi = "alperulger39" };
            hasta.DiyetDegis(new Akdeniz());
            hastalar.Add(hasta);

            hasta = new Hasta("0906202102", "123", new Obez()) { ad = "Arif", soyad = "Munzur", tckno = "39536485831", diyetisyenAdi = "alperulger39" };
            hasta.DiyetDegis(new GlutenFree());
            hastalar.Add(hasta);

            hasta = new Hasta("0906202103", "123", new Obez()) { ad = "Şerif", soyad = "Tıngır", tckno = "79839435121", diyetisyenAdi = "alperulger39" };
            hasta.DiyetDegis(new DenizUrunleri());
            hastalar.Add(hasta);


            hasta = new Hasta("0906202104", "123", new Seker()) { ad = "Refika", soyad = "Aymış", tckno = "5937425231", diyetisyenAdi = "yakuphhanci44" };
            hasta.DiyetDegis(new YesilliklerDunyasi());
            hastalar.Add(hasta);

            hasta = new Hasta("0906202105", "123", new Obez()) { ad = "Meliha", soyad = "Taymış", tckno = "39559085831", diyetisyenAdi = "yakuphhanci44" };
            hasta.DiyetDegis(new GlutenFree());
            hastalar.Add(hasta);

            hasta = new Hasta("0906202106", "123", new Colyak()) { ad = "Sabiha", soyad = "Yanmış", tckno = "79834785351", diyetisyenAdi = "yakuphhanci44" };
            hasta.DiyetDegis(new Akdeniz());
            hastalar.Add(hasta);


            hasta = new Hasta("0906202107", "123", new Obez()) { ad = "Ferdi", soyad = "Tayfun", tckno = "74569725132", diyetisyenAdi = "muratcan5759" };
            hasta.DiyetDegis(new DenizUrunleri());
            hastalar.Add(hasta);

            hasta = new Hasta("0906202108", "123", new Obez()) { ad = "Selda", soyad = "Tezcan", tckno = "11124751365", diyetisyenAdi = "muratcan5759" };
            hasta.DiyetDegis(new Akdeniz());
            hastalar.Add(hasta);

            diyetisyenler.Add(new Diyetisyen("alperulger39", "123456") { ad = "Alper", soyad = "Ülger", tckno = "27698132852", hastalar = Veriler.getHastalar("alperulger39") });
            diyetisyenler.Add(new Diyetisyen("muratcan5759", "123456") { ad = "Muratcan", soyad = "Şen", tckno = "24568908282", hastalar = Veriler.getHastalar("muratcan5759") });
            diyetisyenler.Add(new Diyetisyen("yakuphhanci44", "123456") { ad = "Yakup Hamit", soyad = "Hancı", tckno = "57668132562", hastalar = Veriler.getHastalar("yakuphhanci44") });


        }



        public static Diyetisyen getDiyetisyen(string kullaniciAdi)
        {
            try
            {
                var _diyetisyen = (from k in Veriler.diyetisyenler
                                   where
                                   k.kullaniciAdi == kullaniciAdi
                                   select k).ToList()[0];
                return _diyetisyen;
            }
            catch (Exception)
            {

                return null;
            }
        }
        
        public static bool EkleDiyetisyen(Diyetisyen _diyetisyen)
        {
            bool eklendiMi = false;

            //Bak bakayim ayni kullaniciAdini kullanan baska bir diyetisyen var mi.
            var diyetisyen = Veriler.getDiyetisyen(_diyetisyen.kullaniciAdi);

            //Eger zaten öyle bir diyetisyen yoksa ekle.
            if (diyetisyen == null)
            {
                Veriler.diyetisyenler.Add(_diyetisyen);
                eklendiMi = true;
            }

            return eklendiMi;
        }

        public static Hasta getHasta(string kullaniciAdi)
        {
            try
            {
                var _hasta = (from k in Veriler.hastalar
                                   where
                                   k.kullaniciAdi == kullaniciAdi
                                   select k).ToList()[0];
                return _hasta;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static List<Hasta> getHastalar(string diyetisyenKullaniciAdi)
        {
            try
            {
                var _hasta = (from k in Veriler.hastalar
                              where
                              k.diyetisyenAdi == diyetisyenKullaniciAdi
                              select k).ToList();
                return _hasta;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool EkleHasta(Hasta _hasta)
        {
            bool eklendiMi = false;

            //Bak bakayim ayni kullaniciAdini kullanan baska bir diyetisyen var mi.
            var diyetisyen = Veriler.getHasta(_hasta.kullaniciAdi);

            //Eger zaten öyle bir diyetisyen yoksa ekle.
            if (diyetisyen == null)
            {
                Veriler.hastalar.Add(_hasta);
                eklendiMi = true;
            }

            return eklendiMi;
        }

        public static Admin getAdmin(string kullaniciAdi)
        {
            try
            {
                var _admin = (from k in Veriler.adminler
                                   where
                                   k.kullaniciAdi == kullaniciAdi
                                   select k).ToList()[0];
                return _admin;
            }
            catch (Exception)
            {

                return null;
            }
        }


    }
}
