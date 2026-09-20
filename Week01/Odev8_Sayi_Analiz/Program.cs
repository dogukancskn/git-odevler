Console.WriteLine("10 adet sayı girin");
int pozitifAdet = 0;
int negatifAdet = 0;
int sıfırAdet = 0;

int pozitifToplam = 0;
int negatifToplam = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i + 1}. sayıyı girin");
    int sayi = int.Parse(Console.ReadLine()!);
    if (sayi > 0)
    {
        pozitifAdet++;
        pozitifToplam += sayi;
    }
    else if (sayi < 0)
    {
        negatifAdet++;
        negatifToplam += sayi;
    }
    else if (sayi == 0)
    {
        sıfırAdet++;
    }
}

Console.WriteLine("");
Console.WriteLine("=== SONUÇ ===");
Console.WriteLine("Pozitif Sayı Adedi: " + pozitifAdet);
Console.WriteLine("Negatif Sayı Adedi: " + negatifAdet);
Console.WriteLine("Sıfır Adedi: " + sıfırAdet);
Console.WriteLine("");
Console.WriteLine($"Pozitiflerin Toplamı: {pozitifToplam}");
Console.WriteLine($"Negatiflerin Toplamı: {negatifToplam}");

