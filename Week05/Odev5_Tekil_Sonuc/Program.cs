using Odev5_Tekil_Sonuc.Models;

namespace Odev5_Tekil_Sonuc;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ahmet", Department = "Yazılım", Salary = 45000m },
            new Employee { Id = 2, Name = "Ayşe", Department = "Yazılım", Salary = 50000m },
            new Employee { Id = 3, Name = "Mehmet", Department = "Yazılım", Salary = 45000m },

            new Employee { Id = 4, Name = "Ali", Department = "İnsan Kaynakları", Salary = 35000m },
            new Employee { Id = 5, Name = "Zeynep", Department = "İnsan Kaynakları", Salary = 40000m },
            new Employee { Id = 6, Name = "Arda", Department = "İnsan Kaynakları", Salary = 38000m },

            new Employee { Id = 7, Name = "Fatma", Department = "Muhasebe", Salary = 42000m },
            new Employee { Id = 8, Name = "Ahmet", Department = "Muhasebe", Salary = 46000m },
            new Employee { Id = 9, Name = "Burak", Department = "Muhasebe", Salary = 39000m }
        };

        Employee? firstSoftwareEmployee = employees
            .Where(e => e.Department == "Yazılım")
            .FirstOrDefault();
        if (firstSoftwareEmployee != null)
        {
            Console.WriteLine("1. İlk yazılım çalışanı:");
            Console.WriteLine(firstSoftwareEmployee.Name);
        }

        var employeeById = employees.SingleOrDefault(e => e.Id == 3);
        Console.WriteLine("\n2. Id == 3 olan çalışan:");
        Console.WriteLine(employeeById?.Name);

        // var missingEmployee = employees.Where(e => e.Id == 13);
        // if (missingEmployee.Count() == 0)
        // {
        //     Console.WriteLine("Böyle bir id'ye sahip çalışan yok");
        // }
        Employee? missingEmployee = employees
            .SingleOrDefault(e => e.Id == 100);

        Console.WriteLine("\n3. Olmayan Id araması:");
        Console.WriteLine(missingEmployee?.Name ?? "Çalışan bulunamadı");

        try
        {
            Employee? softwareEmployee = employees
                .SingleOrDefault(e => e.Department == "Yazılım");
            Console.WriteLine(softwareEmployee?.Name);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("\n4. Birden fazla eşleşme nedeniyle hata:");
        }

        //Id araması için SingleOrDefault daha uygundur; çünkü Id'nin
        // benzersiz olması beklenir. Birden fazla eşleşme varsa hata verir.
        // Departman araması için FirstOrDefault daha uygundur; çünkü bir
        // departmanda birden fazla çalışan bulunabilir ve ilk çalışan yeterlidir.
        // Not: FirstOrDefault ilk eşleşeni döndürür; liste sırası önemlidir.

        var employeesStartingWithA = employees
            .Where(e => e.Name.StartsWith("A"))
            .Select(e => new
            {
                e.Name,
                SalaryLabel = $"{e.Salary} TL"
            });
        foreach (var employee in employeesStartingWithA)
        {
            Console.WriteLine($"{employee.Name} - {employee.SalaryLabel}");
        }
        
        bool hasHighSalaryEmployee = employees.Any(e => e.Salary > 100000m);

        // List<Employee> highSalaryEmployees = employees
        //     .Where(e => e.Salary >100000m)
        //     .ToList();

        //     foreach (var employee in employees)
        //     {
        //         Console.WriteLine(employee.Name);
        //     }

    }
}
