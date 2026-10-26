using Odev2_KutuphaneKayitlari.Models;
using Odev2_KutuphaneKayitlari.Services;

namespace Odev2_KutuphaneKayitlari;

class Program
{
    static void Main(string[] args)
    {
        var loan1 = LoanReader.FindById(3);
        Console.WriteLine($"Kitap: {loan1?.BookTitle}");
        var loan2 = LoanReader.FindById(56);
        Console.WriteLine($"{loan2?.BookTitle ?? "Kitap Bulunamadı"}");

        foreach (var loan in LoanReader.loanSnapshots)
        {
            if (!loan.ReturnedAt.HasValue)
            {
                Console.WriteLine($"Açık ödünç: {loan.BookTitle}");
            }
            else
            {
                Console.WriteLine(
                    $"Teslim tarihi: {loan.ReturnedAt?.ToString("dd.MM.yyyy")}");
            }
        }
        foreach (var loan in LoanReader.loanSnapshots)
        {
            Console.WriteLine($"Not: {loan.Note ?? "Not eklenmemiş"}");

        }

        LoanSnapshot? original = LoanReader.FindById(2);
        if (original != null)
        {
            LoanSnapshot copyLoan = original with
            {
                Note = "Gecikme için hatırlatma gönderildi"
            };
            Console.WriteLine($"Orijinal not: {original.Note}");
            Console.WriteLine($"Kopya notu: {copyLoan.Note}");
        }

         LoanSnapshot first = new(
            10, "Ali Yılmaz", "Clean Architecture",
            null, "Örnek not");

        LoanSnapshot second = new(
            10, "Ali Yılmaz", "Clean Architecture",
            null, "Örnek not");
        Console.WriteLine(first==second);
    }
}
