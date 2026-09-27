int[] grades = new int[5];
int grade = 0;
int average = 0;
int total = 0;

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{i + 1}. sınav notunu girin");
    try
    {
        grade = int.Parse(Console.ReadLine() ?? "0");
        if (grade < 0 || 100 < grade)
        {
            Console.WriteLine("UYARI! Puan 0-100 aralığında olmalıdır");
            i--;
            continue;
        }
        else
        {
            grades[i] = grade;
            total += grades[i];
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("HATA! Lütfen geçerli bir sayı girin.");
        i--;
        continue;
    }

}
int maxGrade = grades[0];
int minGrade = grades[0];
for (int i = 1; i < grades.Length; i++)
{
    if (grades[i] > maxGrade)
    {
        maxGrade = grades[i];
    }
}
for (int i = 1; i < grades.Length; i++)
{
    if (grades[i] < minGrade)
    {
        minGrade = grades[i];
    }
}

average = total / grades.Length;
Console.WriteLine();
Console.WriteLine("=== NOT LİSTESİ ===");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{i + 1}. not: {grades[i]}");
}
Console.WriteLine($"Ortalama: {average}");
Console.WriteLine($"En yüksek: {maxGrade}");
Console.WriteLine($"En düşük: {minGrade}");
