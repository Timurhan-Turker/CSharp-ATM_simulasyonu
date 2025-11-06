using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
namespace alistirmaTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet personel gireceksiniz?.: ");
            int personelSayisi = Convert.ToInt32(Console.ReadLine());
            List<Personel> tumPersoneller = new List<Personel>();
            for (int i = 0; i < personelSayisi; i++)
            {
                Console.Write("Lütfen personel adını giriniz:");
                string personelAd = Console.ReadLine() !;

                Console.Write("Lütfen personel deneyim yılını giriniz.:");
                int personelYılı = Convert.ToInt32(Console.ReadLine());

                Personel personeller = new Personel();

                personeller.Ad = personelAd;
                personeller.DeneyimYili = personelYılı;

                tumPersoneller.Add(personeller);
            }
            List<Personel> kidemliPersoneller = new List<Personel>();
            foreach (Personel kidemli in tumPersoneller)
            {
                if (kidemli.DeneyimYili > 5)
                {
                    kidemliPersoneller.Add(kidemli);
                }
            }
            if (kidemliPersoneller.Count == 0)
            {
                Console.WriteLine("5 yıldan kıdemli personel bulunamadı");
            }
            else
            {
                Console.WriteLine("---Kıdemli Personeller---");
                foreach(Personel tecrübeli in kidemliPersoneller)
                {
                    Console.WriteLine($"Persolenin Adı: {tecrübeli.Ad}, Deneyim Süresi: {tecrübeli.DeneyimYili} yıl ");
                }
            }
        }
        public class Personel
        {
            public string Ad { get; set; } = "";
            public int DeneyimYili { get; set; } 
        } 

    }
}
