
using Odev6_Uye_Servisi.Models;

namespace Odev6_Uye_Servisi.Services;

public class GymService
{
    private readonly List<GymMember> _gymMemeber = new List<GymMember>();
    private int _nextId = 1;
    public void AddMember(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Üye adı boş geçilemez");
            return;
        }
        GymMember member = new GymMember(_nextId, name, email);
        _gymMemeber.Add(member);
        _nextId++;

    }

    public void ListMembers()
    {
        if (_gymMemeber.Count == 0)
        {
            Console.WriteLine("Kayıt yok");
            return;
        }

        foreach (GymMember gymMember in _gymMemeber)
        {
            gymMember.Display();
        }
    }

    public GymMember? FindByName(string name)
    {
        foreach (GymMember member in _gymMemeber)
        {
            if (member.Name.Contains(
                name,
                StringComparison.OrdinalIgnoreCase))
            {
                return member;
            }
        }
        return null;
    }
}
