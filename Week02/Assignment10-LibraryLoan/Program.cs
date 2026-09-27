string[] bookNames = new string[12];
string[] memberNames = new string[12];
bool[] isReturnedFlags = new bool[12];
int recordCount = 0;
int menuChoice;
while (true)
{
    Console.WriteLine("=== KÜTÜPHANE ===");
    Console.WriteLine();
    Console.WriteLine("1 - Kitap ödünç ver");
    Console.WriteLine("2 - Kitap iade al");
    Console.WriteLine("3 - Kayıtları listele");
    Console.WriteLine("4 - Çıkış");

    Console.WriteLine("İşlem seçin:");

    try
    {
        menuChoice = int.Parse(Console.ReadLine() ?? "4");
        switch (menuChoice)
        {
            case 1:
                if (recordCount >= bookNames.Length)
                {
                    Console.WriteLine("Dizi dolu kitap veremeyiz");
                    break;
                }
                Console.WriteLine("Kitap ismi:");
                string bookName = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(bookName))
                {
                    Console.WriteLine("Kitap adı boş geçilemez");
                    continue;
                }
                Console.WriteLine("Üye ismi:");
                string memberName = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(memberName))
                {
                    Console.WriteLine("Kitap adı boş geçilemez");
                    continue;
                }

                bookName = bookName.Trim();
                memberName = memberName.Trim();

                bookNames[recordCount] = bookName;
                memberNames[recordCount] = memberName;
                isReturnedFlags[recordCount] = false;
                recordCount++;

                break;
            case 2:
                Console.WriteLine("Kayıt numarası nedir");
                try
                {
                    int recordNo = int.Parse(Console.ReadLine() ?? "0");
                    int index = recordNo - 1;

                    if (index < 0 || index >= recordCount)
                    {
                        Console.WriteLine("Hata: Böyle bir kayıt yok.");
                        break;
                    }
                    if (isReturnedFlags[index])
                    {
                        Console.WriteLine("Bu kitap zaten iade edilmiş.");
                        break;
                    }
                    Console.WriteLine("Kitap iade alındı.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçerli bir kayıt numarası girin");
                    continue;
                }
                break;
            case 3:
                if (recordCount == 0)
                {
                    Console.WriteLine("(Henüz kayıt yok)");
                    break;
                }

                for (int i = 0; i < recordCount; i++)
                {
                    string check = isReturnedFlags[i] ? "İade" : "Ödünç";
                    Console.WriteLine($"{i + 1}. {check} {bookNames[i]} - {memberNames[i]}");
                }
                break;
            case 4:
                Console.WriteLine("Çıkış yapılıyor...");
                return;
            default:
                Console.WriteLine("Tanımsız işlem");
                break;
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("Geçersiz Seçim");
        continue;
    }

}
