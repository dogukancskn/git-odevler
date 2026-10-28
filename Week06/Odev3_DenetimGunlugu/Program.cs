using System.Text;
using Odev3_DenetimGunlugu.Services;

namespace Odev3_DenetimGunlugu;

class Program
{
    static void Main(string[] args)
    {
        string logPath = Path.Combine(AppContext.BaseDirectory, "audit.log");

        using (AuditLogWriter audit = new(logPath))
        {
            audit.Write("Başarılı giriş", "kullanıcı doğrulandu");
            audit.Write("Başarısız raporlama", "rapor kaynağı bulunamadı");
            audit.Write("Ayarlar değişti", "bildirim tercihi güncellendi");
        }

        string[] lines = File.ReadAllLines(logPath);
        Console.WriteLine($"Satır sayısı: {lines.Length}");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        using (MemoryStream memoryStream = new())
        {
            using (StreamWriter streamWriter = new
            (
                memoryStream,
                Encoding.UTF8,
                bufferSize: 1024,
                leaveOpen: true
            ))
            {
                streamWriter.Write("Geçici rapor hazır.");
            }

            memoryStream.Position = 0;

            using (StreamReader streamReader = new
            (
                memoryStream,
                Encoding.UTF8,
                detectEncodingFromByteOrderMarks: true,
                bufferSize: 1024,
                leaveOpen: true
            ))
            {
                string content = streamReader.ReadToEnd();

                Console.WriteLine($"Bellekten okunan: {content}");
            }
        }

        string failLogPath = Path.Combine
            (AppContext.BaseDirectory, "audit-exception.log");

        try
        {
            using (AuditLogWriter failingAudit = new(failLogPath))
            {
                failingAudit.Write("ReportFailed", "exception öncesi kayıt");
                throw new InvalidOperationException("Bilerek fırlatılan hata.");
            }
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Beklenen hata yakalandı.");
        }

        bool readable;
        try
        {
            readable = File.ReadAllLines(failLogPath, Encoding.UTF8).Length > 0;
        }
        catch (InvalidOperationException)
        {
            readable = false;
        }
        Console.WriteLine($"Exception sonrasında günlük okunabildi: {readable}");

        AuditLogWriter disposedWriter = new AuditLogWriter(logPath);
        disposedWriter.Dispose();

        try
        {
            disposedWriter.Write(
                "Test",
                "Bu kayıt yazılmamalı"
            );
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine(
                "Dispose sonrası Write çağrısı engellendi."
            );
        }

        //using bildirimi içinde nesne oluşturduğumuz "()" içidir
        //örneğin nesne oluşturduk bu parantez sonuna gelince dispose edilir
        //using bloğu ise "{}" sonudur ve daha uzun ömürlüdür
    }
}
