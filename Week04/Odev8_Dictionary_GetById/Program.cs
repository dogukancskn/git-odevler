using Odev6_Uye_Servisi.Models;
using Odev6_Uye_Servisi.Services;

namespace Odev8_Dictionary_GetById;

class Program
{
    static void Main(string[] args)
    {
        GymService service = new GymService();
        service.AddMember("Doğukan Coşkun", "dogukan@gmail.com");
        service.AddMember("Volkan Coşkun", "volkan@gmail.com");
        service.AddMember("Ayşe Yılmaz", "ayse@gmail.com");
        service.AddMember("Ensar Şahin", "ensar@gmail.com");

        Console.WriteLine("=== Üye Listesi ===");
        service.ListMembers();

        Console.WriteLine("Aranacak Id'yi girin");
        while (true)
        {
            try
            {
                int search = int.Parse(Console.ReadLine() ?? "0");
                GymMember? gymMember = service.GetById(search);
                if (gymMember != null)
                {
                    Console.WriteLine("\n=== Üye Bulundu ===");
                    gymMember.Display();
                }
                else
                {
                    Console.WriteLine("Üye bulunamadı.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçerli bir değer girin");
                break;
            }
        }

        GymMember? member = service.FindByName("Doğukan");

        if (member != null)
        {
            Console.WriteLine("Mevcut Üye");
            member.Display();
        }
        else
        {
            Console.WriteLine("Üye bulunamadı.");
        }
    }
}
