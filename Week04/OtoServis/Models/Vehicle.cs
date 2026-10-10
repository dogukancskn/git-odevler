using System;

namespace OtoServis.Models;

public class Vehicle : IDescribable
{
    public int Id { get; set; }
    public string Plate { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;

    public Vehicle(int ıd, string plate, string brand, string model)
    {
        Id = ıd;
        Plate = plate;
        Brand = brand;
        Model = model;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Plaka: {Plate}");
        Console.WriteLine($"Marka: {Brand}");
        Console.WriteLine($"Model: {Model}");
    }
}
