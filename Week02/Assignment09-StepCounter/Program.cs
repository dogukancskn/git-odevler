int[] steps = new int[7];
int sayac = 0;
decimal average;
int totalSteps = 0;
int goal;
int goalPlusDays = 0;

while (true)
{
    try
    {
        Console.WriteLine("Haftalık kaç adım hedefliyorsunuz?");
        goal = int.Parse(Console.ReadLine() ?? "8000");
        if (goal < 0)
        {
            Console.WriteLine("UYARI! Adım sayısı negatif olamaz");
            continue;
        }
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("UYARI! Sayısal bir değer girin");
        continue;
    }
}

while (sayac < steps.Length)
{
    Console.WriteLine($"{sayac + 1}. gün kaç adım attınız?");
    try
    {
        int step = int.Parse(Console.ReadLine() ?? "0");
        steps[sayac] = step;
        totalSteps += step;
        sayac++;
        if (step < 0)
        {
            Console.WriteLine("UYARI! Adım sayısı negatif olamaz");
            sayac--;
            continue;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("UYARI! Sayısal bir değer girin");
        continue;
    }
}
average = totalSteps / 7;
Console.WriteLine("\n=== HAFTALIK ADIM ===");
for (int i = 0; i < steps.Length; i++)
{
    if (steps[i] > average)
    {
        goalPlusDays++;
    }
    Console.WriteLine($"{i + 1}. gün {steps[i]}");
}

Console.WriteLine($"\nToplam: {totalSteps}");
Console.WriteLine($"Ortalama: {average}");
Console.WriteLine($"Hedef üstü gün sayısı: {goalPlusDays}");
if (average > goal)
{
    Console.WriteLine("Bu hafta hedefe ulaşamadınız.");
}
else if (goal >= average)
{
    Console.WriteLine("Bu hafta hedefin üzerindeydiniz.");
}
