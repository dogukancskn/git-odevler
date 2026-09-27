string[] names = { "Ayşe", "Mehmet", "Zeynep", "Ali", "Elif" };
while (true)
{
    Console.Write("Aranacak İsim: ");
    string input = Console.ReadLine() ?? "çıkış";

    if (input == "çıkış")
    {
        Console.WriteLine("Program sonlandı.");
        break;
    }
    bool found = false;

    for (int i = 0; i < names.Length; i++)
    {   
        if (input.Equals(names[i], StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{input} Listede bulundı. Sıra {i + 1}");
            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Bu isim listede yok.");
    }
}
