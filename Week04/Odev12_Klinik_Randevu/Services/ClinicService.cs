using System;
using Odev12_Klinik_Randevu.Models;

namespace Odev12_Klinik_Randevu.Services;

public class ClinicService
{
    public int nextId { get; set; } = 1;
    private readonly List<Appointment> _appointments = new List<Appointment>();
    private readonly Dictionary<int, Appointment> _appointmentId = new();

    public void AddAppointment(
        string patientName,
        string doctorName,
        string timeSlot)
    {
        if (string.IsNullOrWhiteSpace(patientName))
        {
            Console.WriteLine("Hasta adı boş geçilemez");
            return;
        }

        Appointment appointment = new
        Appointment(nextId++, patientName, doctorName, timeSlot);
        _appointments.Add(appointment);
        _appointmentId[appointment.Id] = appointment;
    }

    public void ListAppointment()
    {
        if (_appointments.Count == 0)
        {
            Console.WriteLine("Randevu kaydı yok");
            return;
        }
        foreach (Appointment appointment in _appointments)
        {
            appointment.Dispaly();
        }
    }

    public Appointment? GetById(int id)
    {
        if (_appointmentId.TryGetValue(id, out Appointment? appointment))
        {
            return appointment;
        }
        return null;
    }

    public void CancelAppointment(int id)
    {
        Appointment? appointment = GetById(id);
        if (appointment == null)
        {
            Console.WriteLine("Böyle bir randevu yok");
            return;
        }
        if (appointment.IsCancelled)
        {
            Console.WriteLine("Bu randevu zaten iptal edilmiş.");
            return;
        }

        appointment.IsCancelled = true;
        Console.WriteLine("Randevu başarıyla iptal edildi.");
    }

    public int GetActiveCount()
    {
        int sayac = 0;
        foreach (Appointment appointment in _appointments)
        {
            if(appointment.IsCancelled == false)
            {
                sayac++;
            }
        }
        return sayac;
    }
}
