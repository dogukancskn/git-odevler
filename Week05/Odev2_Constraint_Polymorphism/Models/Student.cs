using System;
using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Models;

public class Student : IDescribable, IIdentifiable
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public Student(int id, string fullName)
    {
        Id = id;
        FullName = fullName;
    }
    public string Describe()
    {
        return $"Öğrenci: {FullName}";
    }
}
