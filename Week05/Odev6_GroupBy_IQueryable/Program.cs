using Odev6_GroupBy_IQueryable.Models;

namespace Odev6_GroupBy_IQueryable;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                CustomerName = "Ahmet",
                Category = "Elektronik",
                Amount = 12500m,
                OrderDate = "01.10.2026"
            },
            new Order
            {
                Id = 2,
                CustomerName = "Ayşe",
                Category = "Giyim",
                Amount = 2500m,
                OrderDate = "02.10.2026"
            },
            new Order
            {
                Id = 3,
                CustomerName = "Mehmet",
                Category = "Kitap",
                Amount = 850m,
                OrderDate = "03.10.2026"
            }
        };

        var oderGroup = orders
            .GroupBy(o => o.Category)
            .Select(g => new
            {
                Category = g.Key,
                OrderCount = g.Count(),
                TotalAmount = g.Sum(order => order.Amount),
                AverageAmount = g.Average(order => order.Amount)
            })
            .OrderBy(g => g.Category);

        var customerGroup = orders
            .GroupBy(c => c.CustomerName)
            .Select(g => new
            {
                Id = g.Key,
                OrderCount = g.Count(),
                TotalAmount = g.Sum(order => order.Amount),
                AverageAmount = g.Average(order => order.Amount)
            });

        Console.WriteLine("=== KATEGORİ RAPORU ===");


        foreach (var group in oderGroup)
        {
            Console.WriteLine(
                $"{group.Category}: {group.OrderCount} sipariş, " +
                $"toplam {group.TotalAmount.ToString("N2")} TL, " +
                $"ortalama {group.AverageAmount.ToString("N2")} TL"
            );
        }

        Console.WriteLine("\n=== MÜŞTERİ RAPORU ===");
        foreach (var customer in customerGroup)
        {
            Console.WriteLine(
                $"{customer.Id}: {customer.OrderCount} sipariş, " +
                $"toplam {customer.TotalAmount.ToString("N2")} TL, " +
                $"ortalama {customer.AverageAmount.ToString("N2")} TL"
            );
        }

        var mostSpendCustomer = orders
            .GroupBy(order => order.CustomerName)
            .Select(group => new
            {
                CustomerName = group.Key,
                TotalAmount = group.Sum(order => order.Amount)
            })
            .OrderByDescending(customer => customer.TotalAmount)
            .First();
        Console.WriteLine(
            $"\nEn çok harcayan: {mostSpendCustomer.CustomerName} " +
            $"({mostSpendCustomer.TotalAmount.ToString("N2")} TL)"
        );

        IEnumerable<Order> enumerableQuery = orders
            .Where(o => o.Amount > 100m)
            .OrderBy(o => o.OrderDate);

        IQueryable<Order> queryableQuery = orders
            .AsQueryable()
            .Where(o => o.Amount > 100m)
            .OrderBy(o => o.OrderDate);
        foreach (Order order in enumerableQuery)
        {
            Console.WriteLine(
                $"{order.OrderDate} | {order.CustomerName} | " +
                $"{order.Amount.ToString("N2")} TL"
            );
        }

        // IQueryable sonuçlarını yazdır.
        Console.WriteLine("\n=== IQUERYABLE SONUÇLARI ===");

        foreach (Order order in queryableQuery)
        {
            Console.WriteLine(
                $"{order.OrderDate} | {order.CustomerName} | " +
                $"{order.Amount.ToString("N2")} TL"
            );
        }
        /*Enumerable koleksiyonlar üzerinde çalışmak için, 
        IQueryable ise özellikle veritabanı sorgularını 
        sağlayıcıya iletmek için kullanışlıdır*/
    }
}
