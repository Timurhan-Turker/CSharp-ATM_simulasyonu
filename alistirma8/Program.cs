using System;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

namespace alistirma8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Adet Öğrenci Gireceksiniz?.: ");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

            List<Ogrenci> tumOgrenciler = new List<Ogrenci>();
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write("Lütfen Öğrencinin Adını Giriniz.: ");
                string ogrenciAd = Console.ReadLine()!;

                Console.Write("Lütfen Öğrencinin Notunu Giriniz.: ");
                int ogrenciNot = Convert.ToInt32(Console.ReadLine());

                Ogrenci ogrenciler = new Ogrenci();
                ogrenciler.Ad = ogrenciAd;
                ogrenciler.Not = ogrenciNot;
                tumOgrenciler.Add(ogrenciler);
            }
            int enYuksekNot = 0;
            Ogrenci enBasariliOgrenci = null;
            foreach (Ogrenci ziyaret in tumOgrenciler)
            {
                if (ziyaret.Not > enYuksekNot)
                {
                    enYuksekNot = ziyaret.Not;
                    enBasariliOgrenci = ziyaret;
                }
            }
            if (enBasariliOgrenci != null)
            {
                Console.WriteLine("---Sınıfın En Başarılısı---");
                Console.WriteLine($"Öğrencimizin Adı: {enBasariliOgrenci.Ad} ve Notu: {enYuksekNot} TEBRİKLER");
            }
            else
            {
                Console.WriteLine("Listede hiç öğrenci bulunamadı :( ");
            }
        }
        
        public class Ogrenci
        {
            public string Ad { get; set; } = "";
            public int Not { get; set; }
        }
    }
}
