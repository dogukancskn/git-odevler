using Odev8_Nullable.Models;
using Odev8_Nullable.Services;

namespace Odev8_Nullable;

class Program
{
    static void Main(string[] args)
    {
        CustomerRepository repository = new CustomerRepository();

        Console.Write("Adınızı girin: ");

        string? input = Console.ReadLine();

        string displayName = string.IsNullOrWhiteSpace(input)
            ? "Bilinmeyen"
            : input;

        Console.WriteLine($"Görünen ad: {displayName}");

        Customer? customer = repository.FindByName(displayName);
        Console.WriteLine(customer?.Name ?? "Müşteri Bulunamadı");
        if (customer == null)
        {
            Console.WriteLine("Müşteri Bulunamadı");
        }
        else
        {
            Console.WriteLine(customer.Name);
        }

        List<Customer> customers = repository.customers;
        foreach (var item in customers)
        {
            Console.WriteLine(
                $"{item.Name}: {item.Email ?? "E-posta yok"}"
            );
        }

        foreach (var item in customers)
        {
            if (item.BirthDate.HasValue)
            {
                Console.WriteLine(
                    $"{item.Name}: {item.BirthDate.Value.Year}"
                );
            }
            else
            {
                Console.WriteLine(
                    $"{item.Name}: Doğum tarihi girilmemiş"
                );
            }
        }

        // Console.WriteLine(repository.FindByName("Yok").Name);
        //Unhandled exception.
        
        /*derleyiciye bir değerin null olmadığını söyleyerek null uyarısını susturur.
         Ancak değerin gerçekten null olup olmadığını kontrol etmez.*/

    }
}
