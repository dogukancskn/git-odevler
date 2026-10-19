using System;
using Odev2_Constraint_Polymorphism.Contracts;

namespace Odev2_Constraint_Polymorphism.Models;

public class Book : IDescribable, IIdentifiable
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }
    public string Describe()
    {
        return $"Kitap: {Title} — {Author}";
    }
}
