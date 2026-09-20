Console.WriteLine("Aylık Elektrik Tüketim Miktarını kWh olarak girin");
decimal tüketimMik = decimal.Parse(Console.ReadLine()!);
decimal kalanTüketimMik = 0;

decimal amount = 0;

if (tüketimMik <= 0)
{
    Console.WriteLine("Geçersiz tüketim.");
    return;
}
else if (0 <= tüketimMik && tüketimMik <= 150)
{
    amount = 150 * 2;
}
else if (151 <= tüketimMik && tüketimMik <= 300)
{
    kalanTüketimMik = tüketimMik - 150;
    amount = kalanTüketimMik * 3 + 150 * 2;
}
else if (301 <= tüketimMik)
{
    kalanTüketimMik = tüketimMik - 300;
    amount = kalanTüketimMik * 4 + 150 * 2 + 150 * 3;
}
Console.WriteLine();
Console.WriteLine("=== ELEKTRİK FATURASI ===");
Console.WriteLine($"Tüketim: {tüketimMik} kWh");
Console.WriteLine($"Toplam Tutar: {amount} TL");