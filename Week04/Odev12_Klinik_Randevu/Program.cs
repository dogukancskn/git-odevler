using Odev12_Klinik_Randevu.Services;

namespace Odev12_Klinik_Randevu;

class Program
{
    static void Main(string[] args)
    {
        ClinicService service = new ClinicService();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine();
            Console.WriteLine("=== KLİNİK ===");
            Console.WriteLine("1 - Randevu ekle");
            Console.WriteLine("2 - Randevuları listele");
            Console.WriteLine("3 - Randevu iptal (id)");
            Console.WriteLine("4 - Aktif randevu sayısı");
            Console.WriteLine("5 - Çıkış");
            Console.Write("Seçiminiz: ");

            int choice;

            try
            {
                choice = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (FormatException)
            {
                Console.WriteLine("HATA! Lütfen 1 ile 5 arasında bir sayı girin.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Hasta adı: ");
                        string patientName = Console.ReadLine() ?? "";

                        Console.Write("Doktor adı: ");
                        string doctorName = Console.ReadLine() ?? "";

                        Console.Write("Randevu saati (ör. 14:30): ");
                        string timeSlot = Console.ReadLine() ?? "";

                        service.AddAppointment(
                            patientName,
                            doctorName,
                            timeSlot
                        );

                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("\n--- Randevular ---");
                        service.ListAppointment();

                        break;
                    }

                case 3:
                    {
                        Console.Write("İptal edilecek randevu ID'si: ");

                        int id;

                        try
                        {
                            id = int.Parse(Console.ReadLine() ?? "0");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("HATA! Geçerli bir ID girin.");
                            continue;
                        }

                        service.CancelAppointment(id);

                        break;
                    }

                case 4:
                    {
                        int activeCount = service.GetActiveCount();

                        Console.WriteLine(
                            $"Aktif randevu sayısı: {activeCount}"
                        );

                        break;
                    }

                case 5:
                    {
                        isRunning = false;
                        Console.WriteLine("Klinik uygulaması kapatıldı.");

                        break;
                    }

                default:
                    {
                        Console.WriteLine("HATA! Lütfen 1 ile 5 arasında seçim yapın.");

                        break;
                    }
            }
        }
    }
}
