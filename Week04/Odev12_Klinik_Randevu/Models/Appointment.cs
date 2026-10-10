using System;

namespace Odev12_Klinik_Randevu.Models;

public class Appointment
{
    public Appointment(int id, string patientName, string doctorName, string timeSlot)
    {
        Id = id;
        PatientName = patientName;
        DoctorName = doctorName;
        TimeSlot = timeSlot;
    }

    public int Id { get; set; }
    public string PatientName { get; set; } = string.Empty;
    public string DoctorName { get; set; } = string.Empty;
    public string TimeSlot { get; set; } = "";
    public bool IsCancelled { get; set; } = false;

    public void Dispaly()
    {
        string status = IsCancelled ? "İptal" : $"[{Id}] {TimeSlot} - {PatientName} / {DoctorName} (Aktif)";
        Console.WriteLine(status);
    }
}
