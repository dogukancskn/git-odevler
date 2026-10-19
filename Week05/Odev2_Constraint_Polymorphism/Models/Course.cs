using System;
using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Models;

public class Course : IDescribable, IIdentifiable
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int DurationHours { get; set; }
    public Course(int id, string name, int durationHours)
    {
        Id = id;
        Name = name;
        DurationHours = durationHours;
    }
    public string Describe()
    {
        return $"Kurs: {Name} ({DurationHours} saat)";
    }
}
