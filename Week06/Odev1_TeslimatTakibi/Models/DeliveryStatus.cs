using System;

namespace Odev1_TeslimatTakibi.Models;

public sealed record DeliveryStatus(
    string TrackingCode,
    string Stage,
    int EstimatedMinutes
);

