const int password = 1234;
Console.WriteLine("Şifrenizi Girin");
int userPassword = int.Parse(Console.ReadLine()!);
int sayac = 3;
while (password != userPassword)
{
    sayac--;
    if (sayac == 0)
    {
        Console.WriteLine("Hesabınız geçici olarak kilitlendi");
        break;
    }
    Console.WriteLine("Şifrenizi yanlış girdiniz! Tekrar deneyin.");

    userPassword = int.Parse(Console.ReadLine()!);
}
if (password == userPassword)
{
    Console.WriteLine("Giriş başarılı. Hoş geldiniz.");
}