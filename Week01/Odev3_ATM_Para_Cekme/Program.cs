decimal currentBalance = 12500;
Console.WriteLine($"Mevcut Bakiye: {currentBalance} TL");

while (true)
{
    Console.WriteLine("--- ATM MENÜ ---");
    Console.WriteLine("1 - Para Çek");
    Console.WriteLine("0 - Çıkış");

    Console.Write("Seçiminiz: ");
    int choice = int.Parse(Console.ReadLine()!);


    if (choice == 0)
    {
        Console.WriteLine("Çıkış yapılıyor... İyi günler!");
        break;
    }


    if (choice == 1)
    {

        Console.WriteLine($"Mevcut Bakiye {currentBalance} TL");

        Console.WriteLine("Çekmek İstediğiniz Tutarı Girin:");
        decimal cekilecekTutar = decimal.Parse(Console.ReadLine()!);
        if (cekilecekTutar <= 0)
        {
            Console.WriteLine("Girilen Tutar geçersiz. Lütfen Pozitif bir değer girin");
            return;
        }

        if (cekilecekTutar > currentBalance)
        {
            Console.WriteLine("Yetersiz bakiye.");
            continue;
        }

        Console.WriteLine($"Çekmek İstenilen Tutar {cekilecekTutar} TL");

        currentBalance -= cekilecekTutar;
        Console.WriteLine($"{cekilecekTutar} TL Çekildi");
        Console.WriteLine($"Yeni Bakiye {currentBalance} TL");
    }
    else
    {
        Console.WriteLine("Geçersiz seçim.");
    }
}
