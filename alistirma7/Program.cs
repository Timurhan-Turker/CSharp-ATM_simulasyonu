using System;
using System.Diagnostics;

namespace alistirma7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç farklı adet ürün gireceksiniz.: ");
            int urunSayisi = Convert.ToInt32(Console.ReadLine());

            List<SiparisUrunu> sepet = new List<SiparisUrunu>();

            for (int i = 0; i < urunSayisi; i++)
            {
                Console.Write("Lütfen ürün adını giriniz.: ");
                string urunAdı = Console.ReadLine()!;

                Console.Write("Lütfen birim fiyatını giriniz.: ");
                double urunFiyat = Convert.ToDouble(Console.ReadLine());

                Console.Write("Lütfen ürünün adedini giriniz.: ");
                int urunAdedi = Convert.ToInt32(Console.ReadLine());

                SiparisUrunu Liste = new SiparisUrunu();
                Liste.Ad = urunAdı;
                Liste.Adet = urunAdedi;
                Liste.BirimFiyat = urunFiyat;
                sepet.Add(Liste);
            }
            List<SiparisUrunu> yuksekTutarliUrunler = new List<SiparisUrunu>();
            foreach (SiparisUrunu urun in sepet)
            {
                if (urun.ToplamTutarHesapla() > 100)
                {
                    yuksekTutarliUrunler.Add(urun);
                }
            }
            if (yuksekTutarliUrunler.Count == 0)
            {
                Console.WriteLine("Toplam tutar 100 TL'den fazla olan ürün bulunamadı");
            }
            else
            {
                Console.WriteLine("---Yüksek Tutarlı Ürünler Lisetesi---");
                foreach(SiparisUrunu fis in yuksekTutarliUrunler)
                {
                    Console.WriteLine($"- {fis.Ad} ({fis.Adet} adet) - Toplam: {fis.ToplamTutarHesapla()} TL");
                }
            }
        }
        public class SiparisUrunu
        {
            public string Ad { get; set; } = "";
            public double BirimFiyat { get; set; }
            public int Adet { get; set; }
            public double ToplamTutarHesapla()
            {
                return this.BirimFiyat * this.Adet;
            }
        }
    }
}
