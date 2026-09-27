string[] productNames = new string[15];
int[] quantities = new int[15];
decimal[] lineTotals = new decimal[15];
int orderCount = 0;
int amount;
int totalPrice = 0;
while (true)
{
    Console.WriteLine("=== RESTORAN ===");
    Console.WriteLine("1 - Hamburger     250 TL");
    Console.WriteLine("2 - Pizza         300 TL");
    Console.WriteLine("3 - Makarna       200 TL");
    Console.WriteLine("4 - Salata        120 TL");
    Console.WriteLine("5 - Siparişleri listele");
    Console.WriteLine("6 - Çıkış");
    Console.WriteLine("\nSiparişiniz nedir?");

    try
    {
        string menuChoice = Console.ReadLine() ?? "6";
        int choice = int.Parse(menuChoice);
        if (choice <= 0)
        {
            Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
            continue;
        }


        switch (choice)
        {
            case 1:
                if (orderCount >= productNames.Length)
                {
                    Console.WriteLine("Maksimum 15 siparişe ulaşıldı.");
                    break;
                }
                try
                {
                    productNames[orderCount] = "Hamburger";
                    Console.WriteLine("Kaç adet olsun");
                    amount = int.Parse(Console.ReadLine() ?? "1");
                    if (amount == 0 || amount < 0)
                    {
                        Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                        continue;
                    }

                    quantities[orderCount] = amount;
                    lineTotals[orderCount] = amount * 250;
                    totalPrice += amount * 250;
                    orderCount++;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                    continue;
                }
            case 2:
                if (orderCount >= productNames.Length)
                {
                    Console.WriteLine("Maksimum 15 siparişe ulaşıldı.");
                    break;
                }
                try
                {
                    productNames[orderCount] = "Pizza ";
                    Console.WriteLine("Kaç adet olsun");
                    amount = int.Parse(Console.ReadLine() ?? "1");
                    if (amount == 0 || amount < 0)
                    {
                        Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                        continue;
                    }

                    quantities[orderCount] = amount;
                    lineTotals[orderCount] = amount * 300;
                    totalPrice += amount * 300;
                    orderCount++;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                    continue;
                }
            case 3:
                if (orderCount >= productNames.Length)
                {
                    Console.WriteLine("Maksimum 15 siparişe ulaşıldı.");
                    break;
                }
                try
                {
                    productNames[orderCount] = "Makarna";
                    Console.WriteLine("Kaç adet olsun");
                    amount = int.Parse(Console.ReadLine() ?? "1");
                    if (amount == 0 || amount < 0)
                    {
                        Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                        continue;
                    }

                    quantities[orderCount] = amount;
                    lineTotals[orderCount] = amount * 200;
                    totalPrice += amount * 200;

                    orderCount++;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                    continue;
                }
            case 4:
                if (orderCount >= productNames.Length)
                {
                    Console.WriteLine("Maksimum 15 siparişe ulaşıldı.");
                    break;
                }
                try
                {
                    productNames[orderCount] = "Salata";
                    Console.WriteLine("Kaç adet olsun");
                    amount = int.Parse(Console.ReadLine() ?? "1");
                    if (amount == 0 || amount < 0)
                    {
                        Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                        continue;
                    }

                    quantities[orderCount] = amount;
                    lineTotals[orderCount] = amount * 120;
                    totalPrice += amount * 120;
                    orderCount++;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
                    continue;
                }
            case 5:
                Console.WriteLine("=== SİPARİŞLER ===");
                if (orderCount == 0)
                {
                    Console.WriteLine("Henüz sipariş yok.");
                    break;
                }

                for (int i = 0; i < orderCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {productNames[i]} x {quantities[i]} = {lineTotals[i]}");
                }
                Console.WriteLine($"\nGenel toplam: {totalPrice}");
                break;
            case 6:
                Console.WriteLine("Program sonlandırıldı.");
                return;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("HATA! Geçersiz seçim. LÜtfen tekrar seçin");
        continue;
    }


}

