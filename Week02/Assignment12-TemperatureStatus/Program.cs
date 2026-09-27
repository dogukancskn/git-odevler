int[] temperatures = new int[7];
int degree;
int coldDay = 0;
int normalDay = 0;
int hotDay = 0;
int totalTemperature = 0;
for (int i = 0; i < temperatures.Length; i++)
{
    Console.WriteLine($"{i + 1}. gün hava sıcaklığı");
    try
    {
        degree = int.Parse(Console.ReadLine() ?? "0");
        temperatures[i] = degree;
        totalTemperature += degree;
    }
    catch (FormatException)
    {
        Console.WriteLine("UYARI! Geçerli bir değer girin");
        i--;
        continue;
    }
}

Console.WriteLine();
Console.WriteLine("=== HAFTALIK SICAKLIK ===");

for (int i = 0; i < temperatures.Length; i++)
{
    switch (temperatures[i])
    {
        case <= 15:
            Console.WriteLine($"{i + 1}.gün {temperatures[i]}°C - Soğuk");
            coldDay++;
            break;

        case >= 16 and <= 25:
            Console.WriteLine($"{i + 1}.gün {temperatures[i]}°C - Normal");
            normalDay++;
            break;

        case >= 26:
            Console.WriteLine($"{i + 1}.gün {temperatures[i]}°C - Sıcak");
            hotDay++;
            break;

        default:
            break;
    }
}
decimal average = (decimal)totalTemperature / temperatures.Length;

Console.WriteLine($"\nSoğuk gün: {coldDay}");
Console.WriteLine($"Normal gün: {normalDay}");
Console.WriteLine($"Sıcak gün: {hotDay}");
Console.WriteLine($"Haftalık Ortalama: {average} °C");