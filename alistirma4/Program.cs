using System;
using System.Linq.Expressions;

namespace alistirma4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Urun> sepet = new List<Urun>();
            Console.Write("Sepete kaç adet ürün ekleyeceksiniz.:");
            int urunSayisi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < urunSayisi; i++)
            {
                Console.Write("Lütfen ürünün adını giriniz.:");
                string urunAdı = Console.ReadLine()!;

                Console.Write("Lütfen ürünün fiyatını giriniz.:");
                double urunFiyat = Convert.ToDouble(Console.ReadLine());

                Urun yeniUrun = new Urun();
                yeniUrun.Ad = urunAdı;
                yeniUrun.Fiyat = urunFiyat;
                sepet.Add(yeniUrun);
            }
            Console.WriteLine("---Sepetinizdeki Ürünler---");
            foreach (Urun urun in sepet)
            {
                Console.WriteLine($"- {urun.Ad} (Fiyat: {urun.Fiyat} TL)");
            }
            double toplam = sepet.Sum(u => u.Fiyat);
            Console.WriteLine($"Sepetinizdeki ürünlerin fiyatı.: {toplam} TL'dir.");
        }
     public class Urun
        {
            public string Ad { get; set; } = "";
            public double Fiyat { get; set; }
         
         }
    }
}