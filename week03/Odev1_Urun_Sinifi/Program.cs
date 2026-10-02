using Odev1_Urun_Sinifi.Models;

namespace Odev1_Urun_Sinifi;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product()
        {
            Id = 1,
            Name = "Kulaklık",
            Price = 1299.99m
        };

        Product p2 = new Product()
        {
            Id = 2,
            Name = "Mouse",
            Price = 450m
        };

        Product p3 = new Product()
        {
            Id = 3,
            Name = "Klavye ",
            Price = 890m
        };

        Console.WriteLine("=== ÜRÜNLER ===");
        p1.Display();
        p2.Display();
        p3.Display();
    }
}
