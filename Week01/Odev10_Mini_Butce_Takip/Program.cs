int income = 15000;
int expense = 6500;
int balance = income - expense;

int choice = 0;
while (choice != 4)
{
    Console.Clear();
    Console.WriteLine("=== BÜTÇE TAKİP ===");
    Console.WriteLine("1- Gelir Ekle");
    Console.WriteLine("2- Gider Ekle");
    Console.WriteLine("3- Bakiye göster");
    Console.WriteLine("4-> Çıkış");
    Console.WriteLine("Seçiminizi Yapın");


    choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            Console.WriteLine("Gelir Tutarı");
            int newIncome = int.Parse(Console.ReadLine()!);
            income += newIncome;
            break;
        case 2:
            Console.WriteLine("Gider Tutarı");
            int newExpense = int.Parse(Console.ReadLine()!);
            expense += newExpense;
            break;
        case 3:
            Console.WriteLine("=== BÜTÇE ÖZETİ ===");
            Console.WriteLine($"Toplam Gelir: {income}");
            Console.WriteLine($"Toplam Gider: {expense}");
            Console.WriteLine($"Kalan: {balance} ");
            if (balance < 0)
            {
                Console.WriteLine("Bütçeniz ekside");
            }
            if (balance == 0)
            {
                Console.WriteLine("Bütçeniz dengede");
            }
            if (balance > 0)
            {
                Console.WriteLine("Bütçeniz olumlu durumda.");
            }

            break;
        case 4:
            Console.WriteLine("Çıkış yapıldı");
            break;
        default:
            Console.WriteLine("Geçersiz işlem");
            break;
    }
    if (choice != 4)
    {
        Console.Write("Enter'e Bas...");
        Console.ReadLine();
    }

}