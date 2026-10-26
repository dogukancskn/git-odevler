using System.Diagnostics;
using Odev1_TeslimatTakibi.Models;
using Odev1_TeslimatTakibi.Services;

namespace Odev1_TeslimatTakibi;

class Program
{
    static async Task Main(string[] args)
    {
        using var cancellation = new CancellationTokenSource();

        DeliveryTracker deliveryTracker = new DeliveryTracker();
        
        Console.WriteLine("Takip başlatıldı. İptal etmek için x tuşuna basın.");

        var stopwatch = Stopwatch.StartNew();

        var tracker1 =
             deliveryTracker.WaitForFinalStatusAsync("trk-01", cancellation.Token);

        var tracker2 =
             deliveryTracker.WaitForFinalStatusAsync("trk-02", cancellation.Token);

        var allTrackers = Task.WhenAll(tracker1, tracker2);


        string? input = Console.ReadLine();
        if (input?.ToLower() == "x")
        {
            cancellation.Cancel();
        }

        try
        {
            DeliveryStatus[] result = await allTrackers;

            stopwatch.Stop();

            foreach (var item in result)
            {
                Console.WriteLine(
                   $"{item.TrackingCode} → {item.Stage} " +
                   $"({item.EstimatedMinutes} dk)");
            }

            Console.WriteLine(
                $"Toplam süre: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (OperationCanceledException)
        {

            stopwatch.Stop();
            Console.WriteLine("İzleme iptal edildi.");
        }
        catch (Exception ex)
        {
            stopwatch.Stop();
            Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
        }
    }
}
