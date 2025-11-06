// List<int> tumSayilar = new List<int>();
// Console.WriteLine("Sıfır (0) girilirse program kapanır");
// while (true)
// {
//     Console.Write("Lütfen sayı giriniz.:");
//     int sayi = Convert.ToInt32(Console.ReadLine());
//     if (sayi != 0)
//     {
//         tumSayilar.Add(sayi);
//     }
//     else
//         break;
// }
// List<int> ciftsayilar = new List<int>();  |
// foreach (int mevcutsayi in tumSayilar)    |
// {                                         |
//     if (mevcutsayi % 2 == 0)              |  Burdaki kodların en kısa yolu:
//     {                                     |  List<int> ciftsayilar = tumSayilar.Where(sayi => sayi % 2 == 0).ToList();
//         ciftsayilar.Add(mevcutsayi);      |
//     }
// }
// if (ciftsayilar.Count == 0)
// {
//     Console.WriteLine("Listede hiç çift sayı bulunamadı.");
// }
// else
// {
//     Console.WriteLine("--- Bulunan çift ssayılar ---");
//     foreach(int yazılacak in ciftsayilar)
//     {
//         Console.WriteLine(yazılacak);
//     }
// }

List<string> tumKelimeler = new List<string>();
Console.WriteLine("Çıkmak için hiçbir şey yazmadan ENTER tuşuna basınız");
while (true)
{
    Console.Write("Kelime.: ");
    string kelime = Console.ReadLine()!;
    if (kelime != "")
    {
        tumKelimeler.Add(kelime);
    }
    else
        break;
}
List<string> uzunKelimeler = new List<string>();
foreach (string girilenKelime in tumKelimeler)
{
    if (girilenKelime.Length >= 5)
    {
        uzunKelimeler.Add(girilenKelime);
    }
}
if (uzunKelimeler.Count == 0)
{
    Console.WriteLine("Listede 5 harften uzun kelime bulunamadı.");
}
else
{
    Console.WriteLine("--- 5 Harften Uzun Kelimeler---");
} 
foreach(string yazılacak in uzunKelimeler)
    {
        Console.WriteLine(yazılacak);
    }
