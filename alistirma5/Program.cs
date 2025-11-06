using System;
using System.Diagnostics;
using System.Linq;

namespace alistirma5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç öğrenci gireceksiniz? ");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
            List<Ogrenci> tumOgrenciler = new List<Ogrenci>();
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write("Lütfen öğrenci adını giriniz.: ");
                string girilenAd = Console.ReadLine()!;

                Console.Write("Lütfen not giriniz.: ");
                int girilenNot = Convert.ToInt32(Console.ReadLine());

                Ogrenci yeniOgrenci = new Ogrenci();
                yeniOgrenci.Ad = girilenAd;
                yeniOgrenci.Not = girilenNot;
                tumOgrenciler.Add(yeniOgrenci);
            }
            List<Ogrenci> gecenOgrenciler = new List<Ogrenci>();
            foreach (Ogrenci ogrenci in tumOgrenciler)
            {
                if (ogrenci.Not >= 50)
                {
                    gecenOgrenciler.Add(ogrenci);
                }
            }
            if (gecenOgrenciler.Count == 0)
            {
                Console.WriteLine("Geçen öğrenci bulunamadı.");
            }
            else
            {
                Console.WriteLine("---Geçen Öğrenciler---");
                foreach(Ogrenci gecen in gecenOgrenciler)
                {
                    Console.WriteLine($"- {gecen.Ad} (Not : {gecen.Not})");
                }
            }
        }
        
        public class Ogrenci
        {
            public string Ad { get; set; } = "";
            public int Not { get; set; }
        }
    }
}