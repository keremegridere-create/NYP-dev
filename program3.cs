using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.slayt_3_uygulama__Ekipman_takip
{
    public class Ekipman
    {
        public string DemirbasNo { get; set; }
        public string EkipmanAdi { get; set; }
        public bool OduncDurumu { get; set; }
        public string OduncAlanOgrenciId { get; set; }

        public Ekipman(string demirbasNo, string ad)
        {
            DemirbasNo = demirbasNo;
            EkipmanAdi = ad;
            OduncDurumu = false;
            OduncAlanOgrenciId = null;
        }
    }

    public class Ogrenci
    {
        public string OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Ogrenci(string id, string ad, string soyad)
        {
            OgrenciId = id;
            Ad = ad;
            Soyad = soyad;
        }

    } 
    
     class program
     {
             static void Main(string[] args)
              {
                List<Ekipman> ekipmanlar = new List<Ekipman>();
                List<Ogrenci> ogrenciler = new List<Ogrenci>();
                // Ekipman ekleme
                ekipmanlar.Add(new Ekipman("001", "Laptop"));
                ekipmanlar.Add(new Ekipman("002", "camera"));
                ekipmanlar.Add(new Ekipman("003", "projeksiyon"));
                 // Öğrenci ekleme
                ogrenciler.Add(new Ogrenci("1001", "Emre", "Cengiz"));
                ogrenciler.Add(new Ogrenci("1002", "Ali", "Olgun"));
                ogrenciler.Add(new Ogrenci("1003", "Kerem", "Eğridere"));
                // Ödünç alma işlemi
                string demirbasNo = "001"; // Ödünç alınacak ekipmanın demirbaş numarası
                string ogrenciId = "1001"; // Ödünç alan öğrencinin ID'si
                Ekipman ekipman = ekipmanlar.FirstOrDefault(e => e.DemirbasNo == demirbasNo);
                Ogrenci ogrenci = ogrenciler.FirstOrDefault(o => o.OgrenciId == ogrenciId);
                if (ekipman != null && ogrenci != null && !ekipman.OduncDurumu)
                  {
                   ekipman.OduncDurumu = true;
                   ekipman.OduncAlanOgrenciId = ogrenci.OgrenciId;
                   Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} adlı öğrenci {ekipman.EkipmanAdi} adlı ekipmanı ödünç aldı.");
                    }
                 else
                 {
                  Console.WriteLine("Ekipman ödünç alınamaz veya öğrenci bulunamadı.");
                   } 

         static void IadeAl(Ekipman ekipman, List<Ekipman> ekipmanlar)
              {
                 if (ekipman != null && ekipman.OduncDurumu)
                 {
                    ekipman.OduncDurumu = false;
                    ekipman.OduncAlanOgrenciId = null;
                    Console.WriteLine($"{ekipman.EkipmanAdi} adlı ekipman iade edildi.");
                 }
                else
                {
                    Console.WriteLine("Ekipman iade edilemez veya bulunamadı.");
                }
            }
            Console.ReadLine();
        }
    }
}


