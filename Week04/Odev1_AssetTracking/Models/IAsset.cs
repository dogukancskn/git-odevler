using System;

namespace Odev1_AssetTracking.Models;

public interface IAsset
{
    public string AssetCode { get; set; }
    public string Name { get; set; }
    public bool IsAvailable  { get; set; }

    public string GetDetails();
}
