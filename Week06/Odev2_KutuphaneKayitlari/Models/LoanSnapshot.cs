using System;

namespace Odev2_KutuphaneKayitlari.Models;

public sealed record LoanSnapshot(
    int LoanId,
    string MemberName,
    string BookTitle,
    DateTime? ReturnedAt,
    string? Note);
