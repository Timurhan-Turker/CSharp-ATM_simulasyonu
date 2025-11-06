// Alıştırma 

// 1-

// Console.Write("Kaç adet not gireceksiniz?.:");
// int notSayisi = Convert.ToInt32(Console.ReadLine());

// int[] notlar = new int[notSayisi];
// for (int i = 0; i < notSayisi; i++)
// {
//     Console.Write($"Lütfen {i + 1}. notu giriniz: ");
//     int girilenNot = Convert.ToInt32(Console.ReadLine());
//     notlar[i] = girilenNot;
// }

// int toplam = notlar.Sum();
// double ortalama = notlar.Average();
// Console.WriteLine("Notların toplamı.:" + toplam);
// Console.WriteLine("Notların ortalaması.:" + ortalama);
// if (ortalama >= 50)
// {
//     Console.WriteLine("Durum geçti.");
// }
// else
// {
//     Console.WriteLine("durum kaldı.");
// }

// 2-

Console.Write("Sepete kaç adet ürün ekleyeceksiniz.: ");
int sayiAdedi = Convert.ToInt32(Console.ReadLine());

double[] fiyatlar = new double[sayiAdedi];
for (int i = 0; i < sayiAdedi; i++)
{
    Console.Write($"Lütfen {i + 1}. fiyatı yazınız.");
    double girilenFiyat = Convert.ToDouble(Console.ReadLine());
    fiyatlar[i] = girilenFiyat;
}
double toplam = fiyatlar.Sum();
double enPahalı = fiyatlar.Max();
double enUcuz = fiyatlar.Min();
Console.WriteLine("Fiyatların toplamı.: " + toplam);
Console.WriteLine("Fiyatların en pahalısı.: " + enPahalı);
Console.WriteLine("Fiyatların en ucuzu.: " + enUcuz);
if (toplam >= 500)
{
    var indirim = toplam - ((toplam * 30) / 100);
    Console.WriteLine("İndirimli fiyat.: " + indirim);
}
else
{
    Console.WriteLine("İndirim uygulanmadı.");
}