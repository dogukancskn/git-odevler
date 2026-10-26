using System;
using Odev2_KutuphaneKayitlari.Models;

namespace Odev2_KutuphaneKayitlari.Services;

public class LoanReader
{
    public readonly static List<LoanSnapshot> loanSnapshots = new()
    {
        new LoanSnapshot(
            1, "Ahmet Yılmaz", "Suç ve Ceza",
            DateTime.Now.AddDays(-5), "Zamanında iade edildi"),

        new LoanSnapshot(
            2, "Ayşe Demir", "Kürk Mantolu Madonna",
            null, "Henüz iade edilmedi"),

        new LoanSnapshot(
            3, "Ahmet Yılmaz", "1984",
            DateTime.Now.AddDays(-2), null),

        new LoanSnapshot(
            4, "Mehmet Kaya", "Simyacı",
            null, null),

        new LoanSnapshot(
            5, "Zeynep Arslan", "Dönüşüm",
            DateTime.Now.AddDays(-1), "Hasarsız teslim edildi")
    };

    public static LoanSnapshot? FindById(int loanId)
    {
        foreach (var loan in loanSnapshots)
        {
            if (loanId == loan.LoanId)
            {
                return loan;
            }
        }
        return null;
    }
}
