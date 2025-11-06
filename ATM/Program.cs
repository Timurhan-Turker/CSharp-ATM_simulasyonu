using System;

    namespace ATM
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.Write("Girmek istediğiniz kullanıcı adını giriniz.: ");
            string kullanici = Console.ReadLine()!;

            Console.Write("Şifre belirleyiniz.: ");
            string sifre = Console.ReadLine()!;

            double bakiye = 0;
            bool girisBasarili = false;

            Console.WriteLine("\n--- HESAP GİRİŞ EKRANI ---");

            while (true)
            {
                Console.Write("Kullanıcı adını giriniz.: ");
                string girilenKullaniciAd = Console.ReadLine()!;

                Console.Write("Şifrenizi giriniz.: ");
                string girilenSifre = Console.ReadLine()!;

                if (girilenKullaniciAd == kullanici && girilenSifre == sifre)
                {
                    Console.WriteLine("\nHoş geldiniz! Giriş başarılı.");
                    girisBasarili = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
                }
            }
            if (girisBasarili)
            {
                while (true)
                {
                    Console.WriteLine("\n--- ANA MENÜ ---");
                    Console.WriteLine("1: Para Yatırma");
                    Console.WriteLine("2: Para Çekme");
                    Console.WriteLine("3: Bakiye Sorgulama");
                    Console.WriteLine("4: Çıkış");
                    Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz (1-4): ");

                    string secim = Console.ReadLine()!;

                    switch (secim)
                    {
                        case "1":
                            Console.Write("Yatırmak istediğiniz tutarı giriniz.: ");
                            try
                            {
                                double yatirilanTutar = Convert.ToDouble(Console.ReadLine());
                                if (yatirilanTutar > 0)
                                {
                                    bakiye += yatirilanTutar;
                                    Console.WriteLine($"Hesabınıza {yatirilanTutar:C} yatırıldı. Güncel bakiyeniz: {bakiye:C}");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz tutar girdiniz.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Hatalı giriş. Lütfen sadece sayı giriniz.");
                            }
                            break;
                        case "2":
                            Console.Write("Çekmek istediğiniz tutarı giriniz.: ");
                            try
                            {
                                double cekilenTutar = Convert.ToDouble(Console.ReadLine());
                                if (cekilenTutar > 0 && cekilenTutar <= bakiye)
                                {
                                    bakiye -= cekilenTutar;
                                    Console.WriteLine($"Hesabınızdan {cekilenTutar:C} çekildi. Güncel bakiyeniz: {bakiye:C}");
                                }
                                else if (cekilenTutar > bakiye)
                                {
                                    Console.WriteLine("Yetersiz bakiye.");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz tutar girdiniz.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Hatalı giriş. Lütfen sadece sayı giriniz.");
                            }
                            break;

                        case "3":

                            Console.WriteLine($"Güncel bakiyeniz: {bakiye:C}");
                            break;

                        case "4":

                            Console.WriteLine("Çıkış yapılıyor. İyi günler dileriz.");
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen 1-4 arasında bir değer giriniz.");
                            break;
                    }
                    if (secim == "4")
                    {
                        break;
                    }
                }
            }
                Console.WriteLine("\nProgram sonlandı. Kapatmak için bir tuşa basın.");
                Console.ReadKey();
        }
    }
}
