string[] productNames = new string[10];
decimal[] prices = new decimal[10];
int[] quantities = new int[10];
int productCount = 0;

decimal price;
int quantity;
decimal totalStock = 0;

int menuChoice = 0;
while (menuChoice != 4)
{
    Console.WriteLine("=== ÜRÜN ENVANTERİ ===");
    Console.WriteLine();
    Console.WriteLine("1 - Ürün ekle");
    Console.WriteLine("2 - Envanter listele");
    Console.WriteLine("3 - Toplam stok değeri");
    Console.WriteLine("4 - Çıkış");

    Console.Write("Seçiminiz: ");
    try
    {
        menuChoice = int.Parse(Console.ReadLine() ?? "0");
    }
    catch (FormatException)
    {
        Console.WriteLine("HATA: 1-4 Arası sayı girin");
        continue;
    }

    switch (menuChoice)
    {
        case 1:
            if (productCount >= productNames.Length)
            {
                Console.WriteLine("Hata! Max işlem sayısı sınırına ulaşıldı");
                break;
            }
            Console.Write("Ürün Adı: ");
            string productName = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(productName))
            {
                Console.WriteLine("HATA! Ürün açıklaması boş olamaz");
                continue;
            }
            productName = productName.Trim();

            Console.Write("Ürün Fiyatı: ");

            string amount = Console.ReadLine() ?? "0";
            bool checkPrice = decimal.TryParse(amount, out price);
            if (!checkPrice)
            {
                Console.WriteLine("Geçersiz fiyat");
                continue;
            }
            if (price <= 0)
            {
                Console.WriteLine("Fiyat negatif olamaz");
                continue;
            }


            Console.Write("Ürün miktarı: ");
            try
            {
                quantity = int.Parse(Console.ReadLine() ?? "0");
                if (quantity <= 0)
                {
                    Console.WriteLine("Miktar negatif olamaz");
                    continue;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Hata! Ürün miktarı tam olmalı");
                break;
            }
            productNames[productCount] = productName;
            prices[productCount] = price;
            quantities[productCount] = quantity;
            totalStock += price * quantity;
            productCount++;
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine("=== ENVANTER LİSTESİ ===");

            if (productCount == 0)
            {
                Console.WriteLine("(Henüz ürün yok)");
                break;
            }

            for (int i = 0; i < productCount; i++)
            {
                decimal lineTotal = prices[i] * quantities[i];

                Console.WriteLine(
                    $"{i + 1}. {productNames[i]} — {prices[i]} TL x {quantities[i]} = {lineTotal} TL"
                );
            }

            break;
        case 3:
            Console.WriteLine($"Toplam stok değeri {totalStock}");
            break;
        case 4:
            Console.WriteLine("Çıkış yapılıyor...");
            break;
        default:
            Console.WriteLine("Geçersiz seçim");
            break;
    }
}
Console.WriteLine("Program sona erdi");