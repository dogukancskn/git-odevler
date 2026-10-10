using Odev1_AssetTracking.Models;
using Odev1_AssetTracking.Services;

namespace Odev1_AssetTracking;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new()
        {
            AssetCode = "01",
            IsAvailable = true,
            Brand = "Hp",
            Model = "Victus"
        };
        Laptop laptop2 = new()
        {
            AssetCode = "02",
            IsAvailable = true,
            Brand = "MSI",
            Model = "Katana"
        };
        Laptop laptop3 = new()
        {
            AssetCode = "01",
            IsAvailable = true,
            Brand = "Casper",
            Model = "Excalibur"
        };

        Camera camera1 = new()
        {
            AssetCode="04",
            Resolution="4K",
            IsAvailable=true
        };
        Camera camera2 = new()
        {
            AssetCode="07",
            Resolution="2K",
            IsAvailable=true
        };
        Camera camera3 = new()
        {
            AssetCode="05",
            Resolution="144p",
            IsAvailable=true
        };

        AssetRegistry<Laptop> laptopRegistry = new();
        laptopRegistry.Add(laptop1);
        laptopRegistry.Add(laptop2);
        laptopRegistry.Add(laptop3);

        AssetRegistry<Camera> cameraRegistry = new();
        cameraRegistry.Add(camera1);
        cameraRegistry.Add(camera2);
        cameraRegistry.Add(camera3);

        // laptopRegistry.PrintAll();
        Laptop? currentLaptop = laptopRegistry.FindByCode("03");
        if (currentLaptop != null)
        {

            Console.WriteLine(currentLaptop.GetDetails());
        }
        else
        {
            Console.WriteLine("Laptop bulunamadı.");
        }

        List<Laptop> availableLaptops = laptopRegistry.GetAvailable();
        foreach (Laptop laptop in availableLaptops)
        {
            Console.WriteLine();
            Console.WriteLine(laptop.GetDetails());
        }

        Console.WriteLine("***********************");
        cameraRegistry.PrintAll();
    }
}
