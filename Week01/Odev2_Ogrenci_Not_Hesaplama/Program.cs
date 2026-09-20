Console.WriteLine("Öğrenci Adını Giriniz");
string studentName = Console.ReadLine()!;
if (studentName.Length == 0)
{
    Console.WriteLine("Oğrenci Adı Boş geçilemez");
    return;
}

Console.WriteLine("Öğrenci Vize Notunu Giriniz");
int vize = int.Parse(Console.ReadLine()!);


Console.WriteLine("Öğrenci Final Notunu Giriniz");
int finall = int.Parse(Console.ReadLine()!);

if ( vize<0 ||finall < 0)
{
    Console.WriteLine("Vize yada Finall Sıfırdan Küçük Olamaz");
    return;
}

string harfNotu = "";
bool status = false;

decimal ort = vize * 0.40m + finall * 0.60m;
if (90 <= ort && ort <= 100)
{

    harfNotu = "AA";
    status = true;

}
else if (80 <= ort && ort < 90)
{
    harfNotu = "BA";
    status = true;

}
else if (70 <= ort && ort < 80)
{

    harfNotu = "BB";
    status = true;


}
else if (60 <= ort && ort < 70)
{
    harfNotu = "CB";
    status = true;


}
else if (50 <= ort && ort < 60)
{
    harfNotu = "CC";
    status = true;


}
else if (0 <= ort && ort < 50)
{
    harfNotu = "FF";
    status = false;

}
Console.WriteLine("***  ÖĞRENCİ SONUCU  ***");
Console.WriteLine($"*Öğrenci: {studentName}*\n");
Console.WriteLine($"*Vize: {vize}*");
Console.WriteLine($"*Final: {finall}*");
Console.WriteLine($"*Ortalama: {ort}*");
Console.WriteLine($"*Harf Notu: {harfNotu}*");
if (status) Console.WriteLine("Geçtiniz! Tebrikler!");
else Console.WriteLine("Kaldınız! Üzgünüm!");
