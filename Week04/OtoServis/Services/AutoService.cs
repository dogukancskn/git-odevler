using System;
using OtoServis.Models;

namespace OtoServis.Services;

public class AutoService
{
    private readonly List<Vehicle> _vehicles = new();
    private readonly List<RepairJob> _repairJobs = new();

    private int _nextVehicleId = 1;
    private int _nextRepairId = 1;

    public void AddVehicle(string plate, string brand, string model)
    {

        if (string.IsNullOrWhiteSpace(plate) ||
            string.IsNullOrWhiteSpace(brand) ||
            string.IsNullOrWhiteSpace(model))
        {
            Console.WriteLine("Plaka, marka ve model boş olamaz.");
            return;
        }
        plate = plate.Trim().ToUpperInvariant();
        foreach (Vehicle vehicle in _vehicles)
        {
            if (vehicle.Plate.Equals(
               plate.Trim(),
               StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Bu plakaya sahip bir araç zaten kayıtlı.");
                return;
            }
        }
        Vehicle? newVehicle = new Vehicle(_nextVehicleId++, plate, brand, model);
        _vehicles.Add(newVehicle);
    }

    public void ListVehicles()
    {
        if (_vehicles.Count == 0)
        {
            Console.WriteLine("Kayıtlı araç bulunamadı.");
            return;
        }

        foreach (Vehicle vehicle in _vehicles)
        {
            vehicle.Display();
            Console.WriteLine();
        }
    }

    public Vehicle? FindVehicleByPlate(string plate)
    {

        foreach (Vehicle vehicle in _vehicles)
        {
            if (vehicle.Plate.Equals(
               plate.Trim(),
               StringComparison.OrdinalIgnoreCase))
            {
                return vehicle;
            }
        }

        return null;
    }

    public void AddRepairJob(
        string plate, string description, decimal cost)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("Tamir açıklaması boş olamaz.");
            return;
        }

        if (cost < 0)
        {
            Console.WriteLine("Tamir ücreti negatif olamaz.");
            return;
        }

        Vehicle? vehicle = FindVehicleByPlate(plate);
        if (vehicle == null)
        {
            Console.WriteLine("Bu plakaya kayıtlı araç bulunamadı.");
            return;
        }

        RepairJob repairJob = new RepairJob(_nextRepairId++, vehicle.Id, description, cost);
        _repairJobs.Add(repairJob);
        Console.WriteLine("Tamir kaydı başarıyla oluşturuldu.");
    }

    public void ListRepairJobs()
    {
        if (_repairJobs.Count == 0)
        {
            Console.WriteLine("Tamir kaydı bulunamadı.");
            return;
        }

        foreach (RepairJob repairJob in _repairJobs)
        {
            repairJob.Display();
            Console.WriteLine("");
        }
    }
    public RepairJob? FindRepairById(int id)
    {
        foreach (RepairJob repairJob in _repairJobs)
        {
            if (repairJob.Id == id)
            {
                return repairJob;
            }
        }

        return null;
    }

    public void CompleteRepairJob(int id)
    {
        RepairJob? repairJob = FindRepairById(id);

        if (repairJob == null)
        {
            Console.WriteLine("Tamir kaydı bulunamadı.");
            return;
        }

        if (repairJob.IsCompleted)
        {
            Console.WriteLine("Bu tamir işlemi zaten tamamlanmış.");
            return;
        }

        repairJob.IsCompleted = true;

        Console.WriteLine("Tamir işlemi tamamlandı.");
    }

    public void DeleteVehicleByPlate(string plate)
    {
        Vehicle? vehicle = FindVehicleByPlate(plate);
        if (vehicle == null)
        {
            Console.WriteLine("HATA! Bu plakaya sahip araç bulunamadı.");
            return;
        }
        _vehicles.Remove(vehicle);
        Console.WriteLine("Araç başarıyla silindi.");
    }

}
