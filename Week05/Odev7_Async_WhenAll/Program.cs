using System.Diagnostics;
using Odev7_Async_WhenAll.Services;

namespace Odev7_Async_WhenAll;

class Program
{
    static async Task Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        DataLoader loader = new();

        stopwatch.Start();

        string userName = await loader.LoadUserNameAsync("Doğu");
        int orderCount = await loader.LoadOrderCountAsync(24);
        decimal balance = await loader.LoadBalanceAsync(50000m);
        stopwatch.Stop();

        Console.WriteLine(
             $"Kullanıcı: {userName} | " +
             $"Sipariş: {orderCount} | " +
             $"Bakiye: {balance:N2} TL"
         );
        Console.WriteLine($"Süre: {stopwatch.ElapsedMilliseconds} ms");

        Console.WriteLine("\n=== PARALEL ===");
        stopwatch.Restart();
        Task<string> userTask = loader.LoadUserNameAsync("Engin");
        Task<int> orderTask = loader.LoadOrderCountAsync(25);
        Task<decimal> balanceTask = loader.LoadBalanceAsync(150000m);

        await Task.WhenAll(userTask, orderTask, balanceTask);

        string parallelUser = await userTask;
        int parallelOrderCount = await orderTask;
        decimal parallelBalance = await balanceTask;

        stopwatch.Stop();

        Console.WriteLine(
            $"Kullanıcı: {parallelUser} | " +
            $"Sipariş: {parallelOrderCount} | " +
            $"Bakiye: {parallelBalance:N2} TL"
        );

        Console.WriteLine($"Süre: {stopwatch.ElapsedMilliseconds} ms");

        // 1) İşlemler aynı anda başlatıldığı için toplam bekleme süresi,
        //    normal şartlarda en uzun işlemin süresine (1200 ms) yakın olur.
        //
        // 2) async metot, CPU yoğun bir işi otomatik olarak başka bir
        //    thread'e taşımaz. await, tamamlanmamış asenkron işlemi beklerken
        //    mevcut thread'in başka işler yapabilmesine olanak tanır.
        
    }
}
