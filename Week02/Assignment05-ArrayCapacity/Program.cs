string[] cities = new string[4];
int cityCount = 0;
while (cityCount < cities.Length)
{
    if (cityCount > cities.Length)
    {
        Console.WriteLine("Hata: Maksimum şehir sayısına ulaşıldı (4).");
        break;
    }
    Console.WriteLine("Bir şehir ismi girin");
    string cityName = Console.ReadLine() ?? "";
    if (string.IsNullOrWhiteSpace(cityName))
    {
        Console.WriteLine("Hata: Şehir adı boş olamaz.");
        continue;
    }
    cityName = cityName.Trim();
    cities[cityCount] = cityName;
    cityCount++;

}
if(cityCount==0) Console.WriteLine("Henüz şehir yok");
for (int i = 0; i < cityCount; i++)
{
    Console.WriteLine($"{i+1}. {cities[i]}");
}
