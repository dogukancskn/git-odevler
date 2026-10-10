using OtoServis.Services;

namespace OtoServis;

class Program
{
    static void Main(string[] args)
    {
        AutoService service = new AutoService();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1 - Araç ekle");
            Console.WriteLine("2 - Araçları listele");
            Console.WriteLine("3 - Tamir kaydı oluştur");
            Console.WriteLine("4 - Tamir kayıtlarını listele");
            Console.WriteLine("5 - Tamir işlemini tamamla");
            Console.WriteLine("6 - Araç sil");
            Console.WriteLine("0 - Çıkış");
            Console.Write("Seçiminiz: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("HATA! Lütfen sayısal bir seçim yapın.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Araç plakası: ");
                        string plate = Console.ReadLine() ?? "";

                        Console.Write("Araç markası: ");
                        string brand = Console.ReadLine() ?? "";

                        Console.Write("Araç modeli: ");
                        string model = Console.ReadLine() ?? "";

                        service.AddVehicle(plate, brand, model);
                        break;
                    }

                case 2:
                    service.ListVehicles();
                    break;

                case 3:
                    {
                        Console.Write("Araç plakası: ");
                        string plate = Console.ReadLine() ?? "";

                        Console.Write("Tamir açıklaması: ");
                        string description = Console.ReadLine() ?? "";

                        Console.Write("Tamir ücreti: ");

                        if (!decimal.TryParse(Console.ReadLine(), out decimal cost))
                        {
                            Console.WriteLine("HATA! Geçerli bir ücret girin.");
                            continue;
                        }

                        service.AddRepairJob(plate, description, cost);
                        break;
                    }

                case 4:
                    service.ListRepairJobs();
                    break;

                case 5:
                    {
                        Console.Write("Tamir kayıt ID: ");

                        if (!int.TryParse(Console.ReadLine(), out int repairId))
                        {
                            Console.WriteLine("HATA! Geçerli bir ID girin.");
                            continue;
                        }

                        service.CompleteRepairJob(repairId);
                        break;
                    }
                case 6:
                    {
                        Console.Write("Silinecek aracın plakası: ");
                        string plate = Console.ReadLine() ?? "";

                        service.DeleteVehicleByPlate(plate);
                        break;
                    }

                case 0:
                    isRunning = false;
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;

                default:
                    Console.WriteLine("HATA! Geçersiz menü seçimi.");
                    break;
            }
        }
    }
}