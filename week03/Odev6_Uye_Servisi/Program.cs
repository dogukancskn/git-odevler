using Odev6_Uye_Servisi.Models;
using Odev6_Uye_Servisi.Services;

namespace Odev6_Uye_Servisi;

class Program
{
    static void Main(string[] args)
    {
        GymService service = new GymService();
        service.AddMember("Doğukan Coşkun", "dogukan@gmail.com");
        service.AddMember("Volkan Coşkun", "volkan@gmail.com");
        service.AddMember("Ayşe Yılmaz", "ayse@gmail.com");
        service.AddMember("Ensar Şahin", "ensar@gmail.com");

        service.ListMembers();


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
