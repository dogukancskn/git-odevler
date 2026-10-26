using System;
using Odev1_TeslimatTakibi.Models;

namespace Odev1_TeslimatTakibi.Services;

public class DeliveryTracker
{
    public async Task<DeliveryStatus> CheckStatusAsync(
        string trackingCode,
        string stage,
        int delayMilliseconds,
        CancellationToken cancellationToken)
    {
        await Task.Delay(delayMilliseconds, cancellationToken);
        
        return new DeliveryStatus(trackingCode, stage, 12);
    }

    public async Task<DeliveryStatus> WaitForFinalStatusAsync(
        string trackingCode,
        CancellationToken cancellationToken)
    {
        await CheckStatusAsync(trackingCode, "Hazırlanıyor", 300, cancellationToken);
        await CheckStatusAsync(trackingCode, "Kargoda", 600, cancellationToken);
        return await CheckStatusAsync(trackingCode, "Dağıtımda", 900, cancellationToken);
    }
}
