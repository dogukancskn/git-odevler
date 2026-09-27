int number;
while (true)
{
    Console.WriteLine($"{int.MinValue} ile {int.MaxValue} arasında bir tam sayı girin (çıkış için 0)");
    try
    {
        number = int.Parse(Console.ReadLine() ?? "0");
    }
    catch (FormatException)
    {
        Console.WriteLine("HATA! Lütfen bir tam sayı girin");
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine($"HATA! Lütfen  {int.MinValue}-{int.MaxValue}  arası tam sayı girin");
        continue;
    }

    Console.WriteLine($"Girilen Sayı {number}");

    if (number == 0)
    {
        Console.WriteLine("Program sonlandı.");
        break;
    }

}