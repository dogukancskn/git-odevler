string[] descriptions = new string[10];
decimal[] amounts = new decimal[10];
bool[] isIncomeFlags = new bool[10];

int transactionCount = 0;

decimal totalIncome = 0;
decimal totalExpense = 0;

while (transactionCount < 3)
{
    Console.WriteLine();
    Console.WriteLine("İşlem tipi seçin (Gelir: 1 / Gider: 2)");

    int processChoice;

    try
    {
        processChoice = int.Parse(Console.ReadLine() ?? "0");
    }
    catch (FormatException)
    {
        Console.WriteLine("HATA! Lütfen 1 veya 2 girin.");
        continue;
    }

    switch (processChoice)
    {
        case 1:
            {
                Console.Write("Tutarı girin: ");

                decimal inAmount;

                try
                {
                    inAmount = decimal.Parse(Console.ReadLine() ?? "0");
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA! Geçerli bir tutar girin.");
                    continue;
                }

                if (inAmount <= 0)
                {
                    Console.WriteLine("HATA! Tutar pozitif olmalı.");
                    continue;
                }

                Console.Write("İşlem açıklaması nedir: ");
                string desc = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(desc))
                {
                    Console.WriteLine("HATA! İşlem açıklaması boş olamaz.");
                    continue;
                }

                desc = desc.Trim();

                amounts[transactionCount] = inAmount;
                descriptions[transactionCount] = desc;
                isIncomeFlags[transactionCount] = true;

                totalIncome += inAmount;
                transactionCount++;

                break;
            }

        case 2:
            {
                Console.Write("Tutarı girin: ");

                decimal outAmount;

                try
                {
                    outAmount = decimal.Parse(Console.ReadLine() ?? "0");
                }
                catch (FormatException)
                {
                    Console.WriteLine("HATA! Geçerli bir tutar girin.");
                    continue;
                }

                if (outAmount <= 0)
                {
                    Console.WriteLine("HATA! Tutar pozitif olmalı.");
                    continue;
                }

                Console.Write("İşlem açıklaması nedir: ");
                string desc = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(desc))
                {
                    Console.WriteLine("HATA! İşlem açıklaması boş olamaz.");
                    continue;
                }

                desc = desc.Trim();

                amounts[transactionCount] = outAmount;
                descriptions[transactionCount] = desc;
                isIncomeFlags[transactionCount] = false;

                totalExpense += outAmount;
                transactionCount++;

                break;
            }

        default:
            Console.WriteLine("HATA! Lütfen 1 veya 2 seçin.");
            break;
    }
}

Console.WriteLine();
Console.WriteLine("=== KAYITLI İŞLEMLER ===");

for (int i = 0; i < transactionCount; i++)
{
    string processType = isIncomeFlags[i] ? "Gelir" : "Gider";

    Console.WriteLine(
        $"{i + 1}. [{processType}] {descriptions[i]}: {amounts[i]} TL"
    );
}

Console.WriteLine();
Console.WriteLine($"Toplam Gelir: {totalIncome} TL");
Console.WriteLine($"Toplam Gider: {totalExpense} TL");
Console.WriteLine($"Kalan: {totalIncome - totalExpense} TL");