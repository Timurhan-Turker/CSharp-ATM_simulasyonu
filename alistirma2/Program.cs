//Alıştrıma2
//1.alıştırma

/* 
Console.Write("Listenize kaç ürün ekliyeceksiniz.:");
var ürünAdedi = Convert.ToInt32(Console.ReadLine());

List<string> alisverisListesi = new List<string>();

for (int i = 0; i < ürünAdedi; i++)
{
    Console.Write($"Lütfen {i + 1}. ürünü giriniz.: ");
    string ürün = Console.ReadLine()!;

    alisverisListesi.Add(ürün);
}
Console.WriteLine("--Alışveriş Listeniz---");
foreach (var ürün in alisverisListesi)
{
    Console.WriteLine(ürün);
}
Console.WriteLine($"Listenizde toplam {alisverisListesi.Count} adet ürün var.");
bool varMi = alisverisListesi.Contains("tişört");
Console.WriteLine(varMi);
 */

//2.alıştırma

Console.WriteLine("Lütfen ürün fiyatlarını girin. Bitirmek için '0' (sıfır) girin.");
List<double> Kasa = new List<double>();
while (true)
{
    Console.Write("Fiyat.: ");
    var girilenFiyat = Convert.ToDouble(Console.ReadLine());
    if (girilenFiyat == 0)
    {
        break;
    }
    else
    {
        Kasa.Add(girilenFiyat);
    }
}
if (Kasa.Count > 0)
{
    var toplam = Kasa.Sum();
    var ortalama = Kasa.Average();
    Console.WriteLine($"Toplam tutar.: {Kasa.Sum()}'dır");
    Console.WriteLine($"Fiyat ortlaması {Kasa.Average()}'dir");
}
else
{
    Console.WriteLine("Sepete hiç ürün eklenmedi.");
}