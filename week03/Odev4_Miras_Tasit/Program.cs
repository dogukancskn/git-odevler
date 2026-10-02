using Odev4_Miras_Tasit.Models;

namespace Odev4_Miras_Tasit;

class Program
{
    static void Main(string[] args)
    {
        Car c1 = new()
        {
            Id = 1,
            Brand = "Citroen",
            Models = "C5 AirCross",
            Year = 2024,
        };
        Car c2 = new()
        {
            Id = 2,
            Brand = "Fiat",
            Models = "Doblo",
            Year = 2020,
        };
        c1.Display();
        c2.Display();

    }
}
