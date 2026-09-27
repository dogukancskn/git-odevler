int[] scores = new int[5];
int maxScore = 0;
int minScore = 0;
int score;
int totalPoint = 0;
int average;
int tur = 0;
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"{i + 1}.turun skorunu girin");
    try
    {
        score = int.Parse(Console.ReadLine() ?? "0");
        scores[i] = score;
        totalPoint += score;
        if (i == 0)
        {
            maxScore = score;
            minScore = score;
            tur = i + 1;
        }
        else
        {
            if (score > maxScore)
            {
                maxScore = score;
                tur = i + 1;
            }

            if (score < minScore)
            {
                minScore = score;
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Geçersiz giriş");
        i--;
        continue;
    }
}
average = totalPoint / scores.Length;
Console.WriteLine($"Toplam: {totalPoint}");
Console.WriteLine($"Ortalama: {minScore}");

Console.WriteLine($"En yüksek skor: {maxScore} ({tur}.turda)");
Console.WriteLine($"En düşük skor: {minScore}");