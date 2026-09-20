Console.WriteLine("=== RESTORAN MENÜSÜ ===");
Console.WriteLine("1 - Hamburger     250 TL");
Console.WriteLine("2 - Pizza         300 TL");
Console.WriteLine("3 - Makarna       200 TL");
Console.WriteLine("4 - Salata        120 TL");
Console.WriteLine("5 - Çıkış");

Console.Write("Bir seçim yapın lütfen: ");
int choice = int.Parse(Console.ReadLine()!);

int price = 0;
string product = "";

switch (choice)
{
    case 1:
        product = "Hamburger";
        price = 250;
        break;

    case 2:
        product = "Pizza";
        price = 300;
        break;

    case 3:
        product = "Makarna";
        price = 200;
        break;

    case 4:
        product = "Salata";
        price = 120;
        break;

    case 5:
        Console.WriteLine("Çıkış Yapılıyor...");
        return;

    default:
        Console.WriteLine("Geçersiz Seçim!");
        return;
}

Console.Write("Kaç adet olacak: ");
int total = int.Parse(Console.ReadLine()!);

int amount = total * price;

Console.WriteLine();
Console.WriteLine("*** SİPARİŞ ÖZETİ ***");
Console.WriteLine($"Seçiminiz: {choice}");
Console.WriteLine($"Ürün: {product}");
Console.WriteLine($"Birim Fiyat: {price} TL");
Console.WriteLine($"Adet: {total}");
Console.WriteLine($"Toplam: {amount} TL");