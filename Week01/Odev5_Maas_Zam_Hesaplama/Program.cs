Console.WriteLine("İsim soyisim giriniz");
string nameSurname = Console.ReadLine()!;
Console.WriteLine("Mevcut maaşınızı giriniz");
decimal currentSalary = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Kaç yıldır bu şirkette çalışıyorsunuz?");
decimal workYear = decimal.Parse(Console.ReadLine()!);
decimal newSalary = 0;
string zamOranı = "";
decimal zamTutarı = 0;

if (nameSurname.Length == 0)
{
    Console.WriteLine("UYARI! Çalışan İsmini girin");
    return;
}
if (currentSalary <= 0)
{
    Console.WriteLine("UYARI! Maaş negatif Olamaz");
    return;
}
if (workYear < 0)
{
    Console.WriteLine("UYARI! Çalışma Yılı negatif Olamaz");
    return;
}

if (0 <= workYear && workYear <= 2)
{
    zamTutarı = currentSalary * 0.10m;
    zamOranı = "%10";
    newSalary = zamTutarı + currentSalary;
}
else if (3 <= workYear && workYear <= 5)
{
    zamTutarı = currentSalary * 0.15m;
    zamOranı = "%15";
    newSalary = zamTutarı + currentSalary;

}
else if (6 <= workYear && workYear <= 10)
{
    zamOranı = "%20";
    zamTutarı = currentSalary * 0.20m;
    newSalary = zamTutarı + currentSalary;

}
else if (10 < workYear)
{
    zamOranı = "%25";
    zamTutarı = currentSalary * 0.25m;
    newSalary = zamTutarı + currentSalary;

}

Console.WriteLine();
Console.WriteLine("*** MAAŞ BİLGİSİ ***");
Console.WriteLine($"Çalışan: {nameSurname}");
Console.WriteLine($"Mevcut Maaş: {currentSalary}TL");
Console.WriteLine($"Çalışma Süresi: {workYear} ");
Console.WriteLine();
Console.WriteLine($"Zam Oranı: {zamOranı}");
Console.WriteLine($"Zam Tutarı: {zamTutarı} TL");
Console.WriteLine($"Yeni Maaş: {newSalary} TL");