decimal balance = 8000m;
decimal[] amounts = new decimal[8];
int transactionsCount = 0;
while (transactionsCount < amounts.Length)
{
    Console.WriteLine("Çekilecek tutarı girin");
    decimal amount;
    try
    {
        amount = decimal.Parse(Console.ReadLine() ?? "0");
        if (amount <= 0)
        {
            Console.WriteLine("HATA! Çekilecek tutar 0'dan büyük olmalı.");
            continue;
        }
        if (amount > balance)
        {
            Console.WriteLine("Yetersiz bakiye");
            break;
        }
        amounts[transactionsCount] = amount;
        balance -= amount;
        Console.WriteLine($"{amount} TL çekildi");
        Console.WriteLine($"Kalan bakiye: {balance} TL");
        transactionsCount++;

    }
    catch (FormatException)
    {
        Console.WriteLine("HATA! Lütfen geçerli bir değer girin");
        continue;
    }

}
if (transactionsCount == 0)
{
    Console.WriteLine("Henüz işlem yok");
}
Console.WriteLine("\n*** İşlem geçmişi ***");

for (int i = 0; i < transactionsCount; i++)
{
    Console.WriteLine($"{i + 1}.işlemde {amounts[i]} TL çekildi");
}