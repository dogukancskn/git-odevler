using System;

namespace Odev8_Nullable.Models;

public  class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
    public Customer(int id, string name, string? email, DateTime? birthDate)
    {
        Id = id;
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }



}
