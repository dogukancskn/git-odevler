using System;

namespace Odev4_Miras_Tasit.Models;

public class Car : Vehicle
{
    public string Models { get; set; }=string.Empty;
    public int Year { get; set; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Otomobil {Models} ({Year})");
    }
}
