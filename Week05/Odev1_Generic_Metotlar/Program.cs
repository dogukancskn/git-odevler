using Odev1_Generic_Metotlar.Services;

namespace Odev1_Generic_Metotlar;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 20, 30 };
        List<string> names = new List<string>
        {
            "Ali", "Ayşe", "Mehmet"
        };
        List<decimal> prices = new()
        {
            10m, 49.50m, 99.90m
        };
        Console.WriteLine("=== GENERIC METOTLAR ===");
        int lastNumber = ListHelper.GetLast(numbers);
        Console.WriteLine($"Son sayı: {lastNumber}");

        int nameCount = ListHelper.CountItems(numbers);
        Console.WriteLine($"Son sayı: {nameCount}");

        List<decimal> reversedPrices = ListHelper.Reverse(prices);
        Console.WriteLine(
            $"Ters fiyatlar: {string.Join(", ", reversedPrices)}"
        );

        /* Object kullansaydık tür dönüşümü yapmamız gerekebilirdi 
        ve hata alma ihtimalimiz artardı. 
        Generic kullanarak kodu daha güvenli ve kolay yazabili*/

    }
}
