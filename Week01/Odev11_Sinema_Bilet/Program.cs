int ticket = 250;
int studentTicket = 150;

int ogrenciAdeti = 0;
int tamAdeti = 0;

int choice = 0;
int price = 0;

while (choice != 3)
{
    Console.WriteLine("=== SİNEMA BİLET SİSTEMİ ===");
    Console.WriteLine("1- Tam Bilet");
    Console.WriteLine("2- Öğrenci Bileti");
    Console.WriteLine("3- Çıkış");

    Console.WriteLine("Bilet türünü seçin");
    choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            Console.WriteLine("Kaç tane bilet olacak");
            tamAdeti += int.Parse(Console.ReadLine()!);
            price += ticket * tamAdeti;
            break;
        case 2:
            Console.WriteLine("Kaç tane bilet olacak");
            ogrenciAdeti += int.Parse(Console.ReadLine()!);
            price += studentTicket * ogrenciAdeti;
            break;
        case 3:
            Console.WriteLine("Çıkış Yapılııyor...");
            break;
        default:
            Console.WriteLine("Geçersiz Seçim...");
            break;


    }

}
Console.WriteLine();
Console.WriteLine("=== SONUÇ ===");
Console.WriteLine($"Öğrenci Bilet Adedi: {ogrenciAdeti}");
Console.WriteLine($"Tam Bilet Adedi: {tamAdeti}");
Console.WriteLine($"Toplam: {price} TL");
