int breadPrice = 15;
int milkPrice = 35;
int cheesePrice = 180;
int eggPrice = 120;
int chocolatePrice = 50;

int breadCount = 0;
int milkCount = 0;
int cheeseCount = 0;
int eggCount = 0;
int chocolateCount = 0;

int choice = 0;

int totalProduct = 0;
int totalPrice = 0;

while (choice != 7)
{
    Console.WriteLine();
    Console.WriteLine("=== MARKET KASA SİSTEMİ ===");
    Console.WriteLine("1- Ekmek       15 TL");
    Console.WriteLine("2- Süt         35 TL");
    Console.WriteLine("3- Peynir     180 TL");
    Console.WriteLine("4- Yumurta    120 TL");
    Console.WriteLine("5- Çikolata    50 TL");
    Console.WriteLine("6- Sepeti Göster");
    Console.WriteLine("7- Kasayı Kapat");

    Console.Write("Seçiminiz: ");
    choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            Console.Write("Kaç adet ekmek: ");
            int bread = int.Parse(Console.ReadLine()!);

            if (bread <= 0)
            {
                Console.WriteLine("Geçersiz adet!");
                break;
            }

            breadCount += bread;
            totalProduct += bread;
            totalPrice += breadPrice * bread;

            Console.WriteLine($"{bread} adet ekmek sepete eklendi.");
            break;

        case 2:
            Console.Write("Kaç adet süt: ");
            int milk = int.Parse(Console.ReadLine()!);

            if (milk <= 0)
            {
                Console.WriteLine("Geçersiz adet!");
                break;
            }

            milkCount += milk;
            totalProduct += milk;
            totalPrice += milkPrice * milk;

            Console.WriteLine($"{milk} adet süt sepete eklendi.");
            break;

        case 3:
            Console.Write("Kaç adet peynir: ");
            int cheese = int.Parse(Console.ReadLine()!);

            if (cheese <= 0)
            {
                Console.WriteLine("Geçersiz adet!");
                break;
            }

            cheeseCount += cheese;
            totalProduct += cheese;
            totalPrice += cheesePrice * cheese;

            Console.WriteLine($"{cheese} adet peynir sepete eklendi.");
            break;

        case 4:
            Console.Write("Kaç adet yumurta: ");
            int egg = int.Parse(Console.ReadLine()!);

            if (egg <= 0)
            {
                Console.WriteLine("Geçersiz adet!");
                break;
            }

            eggCount += egg;
            totalProduct += egg;
            totalPrice += eggPrice * egg;

            Console.WriteLine($"{egg} adet yumurta sepete eklendi.");
            break;

        case 5:
            Console.Write("Kaç adet çikolata: ");
            int chocolate = int.Parse(Console.ReadLine()!);

            if (chocolate <= 0)
            {
                Console.WriteLine("Geçersiz adet!");
                break;
            }

            chocolateCount += chocolate;
            totalProduct += chocolate;
            totalPrice += chocolatePrice * chocolate;

            Console.WriteLine($"{chocolate} adet çikolata sepete eklendi.");
            break;

        case 6:

            Console.WriteLine();
            Console.WriteLine("=== SEPET ===");

            Console.WriteLine($"Ekmek: {breadCount} adet");
            Console.WriteLine($"Süt: {milkCount} adet");
            Console.WriteLine($"Peynir: {cheeseCount} adet");
            Console.WriteLine($"Yumurta: {eggCount} adet");
            Console.WriteLine($"Çikolata: {chocolateCount} adet");

            Console.WriteLine("-------------------------");
            Console.WriteLine($"Toplam Ürün: {totalProduct}");
            Console.WriteLine($"Toplam Tutar: {totalPrice} TL");

            break;

        case 7:

            Console.WriteLine();
            Console.WriteLine("=== KASA ===");

            decimal discount = 0;

            if (totalPrice >= 1000)
            {
                discount = totalPrice * 0.20m;
            }
            else if (totalPrice >= 500)
            {
                discount = totalPrice * 0.10m;
            }

            decimal payablePrice = totalPrice - discount;

            Console.WriteLine($"Toplam Ürün: {totalProduct}");
            Console.WriteLine($"Ara Toplam: {totalPrice} TL");
            Console.WriteLine($"İndirim: {discount} TL");
            Console.WriteLine($"Ödenecek Tutar: {payablePrice} TL");

            Console.WriteLine();
            Console.WriteLine("Kasadan çıkılıyor...");

            break;

        default:

            Console.WriteLine("Geçersiz seçim!");

            break;
    }
}