using Odev3_Metotlar.Models;

namespace Odev3_Metotlar;

class Program
{
    static void Main(string[] args)
    {
        BankAccount b1 = new BankAccount();

        b1.OwnerName = "Doğukan Coşkun";
        b1.Balance = 5000m;

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n=== Coşkun Bankası ===");
            Console.WriteLine("1 - Hesap Bilgilerini Göster");
            Console.WriteLine("2 - Para Yatır");
            Console.WriteLine("3 - Para Çek");
            Console.WriteLine("4 - Hesap Özetini Göster");
            Console.WriteLine("5 - Çıkış");
            Console.Write("Seçiminiz: ");

            choice = int.Parse(Console.ReadLine() ?? "5");

            switch (choice)
            {
                case 1:
                    b1.Display();
                    break;

                case 2:
                    Console.Write("Yatırılacak tutar: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine() ?? "0");

                    b1.Deposit(depositAmount);
                    break;

                case 3:
                    Console.Write("Çekilecek tutar: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine() ?? "0");

                    b1.Withdraw(withdrawAmount);
                    break;

                case 4:
                    Console.WriteLine(b1.GetSummary());
                    break;

                case 5:
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}