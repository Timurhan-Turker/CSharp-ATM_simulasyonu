using System;
using System.Linq;
using System.Linq.Expressions;

namespace alistirma6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet ürün gireceksiniz.: ");
            int urunSayisi = Convert.ToInt32(Console.ReadLine());

            List<EnvanterUrunu> tumUrunler = new List<EnvanterUrunu>();
            for (int i = 0; i < urunSayisi; i++)
            {
                Console.Write("Lütfen ürünün adını giriniz.: ");
                string urunAdı = Console.ReadLine()!;

                Console.Write("Lütfen stok adedini giriniz.: ");
                int urunStok = Convert.ToInt32(Console.ReadLine());

                EnvanterUrunu urunler = new EnvanterUrunu();
                urunler.Ad = urunAdı;
                urunler.StokAdedi = urunStok;
                tumUrunler.Add(urunler);
            }
            List<EnvanterUrunu> stoktaOlmayanlar = new List<EnvanterUrunu>();
            foreach (EnvanterUrunu urun in tumUrunler)
            {
                if (urun.StokAdedi == 0)
                {
                    stoktaOlmayanlar.Add(urun);
                }
            }
            if (stoktaOlmayanlar.Count == 0)
            {
                Console.WriteLine("Stokta olmayan ürün bulunamadı");
            } 
            else
            {
                Console.WriteLine("---Stokta Olmayan Ürünler---");
                foreach(EnvanterUrunu olmayan in stoktaOlmayanlar)
                {
                    Console.WriteLine($"Ürünün adı: {olmayan.Ad}, Stok Adedi: {olmayan.StokAdedi}");
                }
            }
        }
        public class EnvanterUrunu
        {
            public string Ad { get; set; } = "";
            public int StokAdedi { get; set; }
        }
    }
}
