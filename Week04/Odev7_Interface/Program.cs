using Odev7_Interface.Models;

namespace Odev7_Interface;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product()
        {
            Id=1,
            Name="Hp Victus"
        };

        Customer customer = new()
        {
            Id=1,
            Name="Doğukan"
        };

        // Console.WriteLine(product.GetDisplayName());
        // Console.WriteLine(customer.GetDisplayName());

        //List<IIdentifiable> identifiables = new() {customer,product};
        List<IIdentifiable> identifiables = new List<IIdentifiable>();
        identifiables.Add(customer);
        identifiables.Add(product);

        foreach(IIdentifiable identifiable in identifiables)
        {
            Console.WriteLine(identifiable.GetDisplayName());
        }
    }
}
