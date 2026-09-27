string productName;
string price;
decimal amount;
while (true)
{
    Console.WriteLine("Ürün adnı girin");
    productName = Console.ReadLine() ?? "";
    if (string.IsNullOrWhiteSpace(productName))
    {
        Console.WriteLine("HATA! Ürün adı boş geçilemez");
        continue;
    }
    Console.WriteLine("Ürün fiyatını girin");
    price = Console.ReadLine() ?? "0";
    bool check = decimal.TryParse(price, out amount);
    if (!check)
    {
        Console.WriteLine("Hata: Fiyat sayı olmalı. Örnek: 1500 veya 1500.50");
        continue;
    }
    else if (amount <= 0)
    {
        Console.WriteLine("Hata: Fiyat pozitif olmalı");
        continue;
    }
    else
    {
        Console.WriteLine("Program sona erdi");
        break;
    }

}
Console.WriteLine("\n=== ÜRÜN ===");
Console.WriteLine($"Ürün: {productName}");
Console.WriteLine($"Fiyatı: {amount}");