using System;

namespace OtoServis.Models;

public class RepairJob : IDescribable
{
    public RepairJob(
        int ıd,
        int vehicleId,
        string description,
        decimal cost)
    {
        Id = ıd;
        VehicleId = vehicleId;
        Description = description;
        Cost = cost;
    }

    public int Id { get; set; }
    public int VehicleId { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public bool IsCompleted { get; set; } = false;
    public void Display()
    {
        string status = IsCompleted ? "Tamamlandı" : "Devam ediyor";

        Console.WriteLine($"Tamir ID: {Id}");
        Console.WriteLine($"Araç ID: {VehicleId}");
        Console.WriteLine($"Açıklama: {Description}");
        Console.WriteLine($"Ücret: {Cost:N2} TL");
        Console.WriteLine($"Durum: {status}");
    }
}
