using System;

namespace Odev6_Uye_Servisi.Models;

public class GymMember
{
    public GymMember()
    {
    }
    public GymMember(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public void Display()
    {
        Console.WriteLine($"[{Id}] {Name} {Email}");
    }

    public string GetSummary()
    {
        return $"{Name} - {Email}";
    }

}
