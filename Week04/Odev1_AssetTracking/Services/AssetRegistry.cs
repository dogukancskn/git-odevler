using System;
using Odev1_AssetTracking.Models;

namespace Odev1_AssetTracking.Services;

public class AssetRegistry<T> where T : IAsset
{
    private readonly List<T> _assets = new();
    public void Add(T asset)
    {
        foreach (T currentAsset in _assets)
        {
            if (currentAsset.AssetCode == asset.AssetCode)
            {
                Console.WriteLine($"HATA: {asset.AssetCode} kodu zaten kayıtlı");
                return;
            }
        }
        _assets.Add(asset);
    }

    public T? FindByCode(string assetCode)
    {
        foreach (T asset in _assets)
        {
            if (asset.AssetCode == assetCode)
            {
                return asset;
            }
        }
        return default;
    }

    public List<T> GetAvailable()
    {
        List<T> availableAssets = new();
        foreach (T asset in _assets)
        {
            if (asset.IsAvailable)
            {
                availableAssets.Add(asset);
            }
        }
        return availableAssets;
    }

    public void PrintAll()
    {
        if (_assets.Count == 0)
        {
            Console.WriteLine("Kayıtlı varlık bulunamadı.");
            return;
        }
        foreach (T asset in _assets)
        {
            Console.WriteLine($"Varlık Kodu: {asset.AssetCode}");
            Console.WriteLine($"Kullanılabilir: {(asset.IsAvailable ? "Evet" : "Hayır")}");
            Console.WriteLine($"Detaylar: {asset.GetDetails()}");
            Console.WriteLine("------------------------------");
        }
    }

    public bool TryReserve(string assetCode)
    {
        T? asset = FindByCode(assetCode);

        if (asset == null)
        {
            return false;
        }

        if (!asset.IsAvailable)
        {
            return false;
        }

        asset.IsAvailable = false;

        return true;
    }
}
