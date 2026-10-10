using System;

namespace Odev1_AssetTracking.Models;

public class Camera : IAsset
{
    public string AssetCode { get; set; } = string.Empty;
    public string Name { get; set; } = "Kamera";
    public bool IsAvailable { get; set; }
    public string Resolution { get; set; } = string.Empty;

    public string GetDetails()
    {
         return $"{Name}: {Resolution}";
    }
}
