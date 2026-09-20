Random random = new Random();
int num = random.Next(1, 101);
int sayac = 0;
while (true)
{
    Console.WriteLine("Tahmininizi Girin");
    int guess = int.Parse(Console.ReadLine()!);
    sayac++;
    if (guess == num)
    {
        Console.WriteLine($"Tahmininiz: {guess}");
        break;
    }
    else if (guess < num)
    {
        Console.WriteLine("Daha büyük bir sayı girin.");
    }
    else if (guess > num)
    {
        Console.WriteLine("Daha küçük bir sayı girin.");
    }
}
Console.WriteLine($"{sayac}  tahminde doğru bildiniz.");
