using System.Globalization;
using Odev4_Extension_LINQ.Extensions;
using Odev4_Extension_LINQ.Models;

namespace Odev4_Extension_LINQ;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo tr = CultureInfo.GetCultureInfo("tr-TR");
        List<Product> products = new List<Product>
        {
            new Product(1, "Klavye", 750m, 10),
            new Product(2, "Mouse", 250m, 0),
            new Product(3, "Monitör", 3500m, 5),
            new Product(4, "Telefon", 5500m, 0),
            new Product(5, "Kulaklık", 450m, 8),
            new Product(6, "USB Bellek", 150m, 20)
        };

        bool hasAnyStock = products.HasAny(p => p.Stock == 0);
        Console.WriteLine(
           $"Stokta olmayan ürün var mı: {hasAnyStock}"
       );

        string expensiveProducts = products
         .Where(p => p.Price >= 500)
         .Select(p => p.Name)
         .OrderBy(name => name, StringComparer.Create(tr, false))
         .JoinForDisplay(name => name);
        Console.WriteLine($"Pahalı ürünler: {expensiveProducts}");

        bool hasVeryExpensive = products.Any(p => p.Price > 5000m);

        Console.WriteLine(
            $"5000 TL üstü ürün var mı: {hasVeryExpensive}"
        );

        int inStockCount = products.Count(p => p.Stock > 0);

        Console.WriteLine(
            $"Stokta olan ürün sayısı: {inStockCount}"
        );

        string totalPrice = products
           .Select(p => p.Price)
           .SumFormatted(total => $"{total.ToString("N2", tr)} TL");

        Console.WriteLine($"Toplam fiyat: {totalPrice}");
    }

}
