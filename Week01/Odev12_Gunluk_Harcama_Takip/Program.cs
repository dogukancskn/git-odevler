decimal[] spend = new decimal[5];
decimal totalSpend = 0m;
for (int i = 0; i < spend.Length; i++)
{
    Console.WriteLine($"{i + 1}. Harcama miktarını girin");
    spend[i] = decimal.Parse(Console.ReadLine()!);
    totalSpend += spend[i];
}
Console.WriteLine("=== GÜNLÜK HARCAMA ===");
Console.WriteLine($"Toplam Harcama: {totalSpend}");

if (totalSpend < 500)
{
    Console.WriteLine("Bugün kontrollü harcama yaptınız");
}
if (500<=totalSpend && totalSpend<=1000)
{
    Console.WriteLine("Bugünkü harcamanız normal seviyede");
}
if (1000 < totalSpend)
{
    Console.WriteLine("Bugün biraz fazla harcadınız.");
}