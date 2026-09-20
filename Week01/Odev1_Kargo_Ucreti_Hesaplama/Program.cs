Console.WriteLine("Gönderen Adı Soyadı");
string sender = Console.ReadLine()!;
if (sender.Length != 0)
{

    Console.WriteLine("Paket Ağırlığını Girin (kg)");
    decimal kg = decimal.Parse(Console.ReadLine()!);

    if (kg == 0)
    {
        Console.WriteLine("UYARI! Ağırlık sıfır olamaz.");
        return;
    }
    else
    {
        while (kg != 0)
        {
            decimal price = 0m;
            string postType = "";

            Console.WriteLine("--- Menü ---");
            Console.WriteLine("1-> Şehir İçi");
            Console.WriteLine("2-> Şehir Dışı");
            int cityChoice = int.Parse(Console.ReadLine()!);

            switch (cityChoice)
            {
                case 1:
                    Console.WriteLine("Şehir içi seçildi");
                    postType = "Şehir içi";

                    if (kg > 0 && kg <= 2)
                    {
                        price = 100;
                    }
                    else if (kg <= 5)
                    {
                        price = 150;
                    }
                    else
                    {
                        price = 250;
                    }

                    break;
                case 2:
                    Console.WriteLine("Şehir dışı seçildi");
                    postType = "Şehir dışı";

                    if (kg > 0 && kg <= 2)
                    {
                        price = 175;
                    }
                    else if (kg <= 5)
                    {
                        price = 225;
                    }
                    else
                    {
                        price = 325;
                    }

                    break;
                default:
                    Console.Write("Geçersiz Seçim");
                    break;
            }

            if (cityChoice == 1 || cityChoice == 2)
            {
                Console.WriteLine("*** ÖZET ***");
                Console.WriteLine($"* Gönderen: {sender}");
                Console.WriteLine($"* Gönderi Tipi: {postType}");
                Console.WriteLine($"* Kargo Ücreti: {price} TL");
            }

            Console.WriteLine();
            Console.WriteLine("Yeni paket ağırlığı girin (Çıkmak için 0):");
            kg = decimal.Parse(Console.ReadLine()!);


        }
    }
}
else
{
    Console.WriteLine("UYARI! Kullanıcı adı boş olamaz");
    return;
}


