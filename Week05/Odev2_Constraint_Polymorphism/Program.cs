using Odev2_Constraint_Polymorphism.Contracts;
using Odev2_Constraint_Polymorphism.Models;
using Odev2_Constraint_Polymorphism.Services;

namespace Odev2_Constraint_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book(1, "Temiz Kod", "Robert Martin"),
            new Book(2, "Sefiller", "Victor Hugo")
        };

        List<Course> courses = new List<Course>
        {
            new Course(3, "Backend Temelleri", 90),
            new Course(4, "C# Programlama", 60)
        };

        List<Student> students = new List<Student>
        {
            new Student(5, "Ada Yılmaz"),
            new Student(6, "Ali Demir")
        };
        Console.WriteLine("=== KİTAPLAR ===");
        ItemPrinter.PrintDescriptions(books);
        ItemPrinter.PrintIds(books);


        Console.WriteLine("\n=== KURSLAR ===");
        ItemPrinter.PrintDescriptions(courses);
        ItemPrinter.PrintIds(courses);

        Console.WriteLine("\n=== ÖĞRENCİLER ===");
        ItemPrinter.PrintDescriptions(students);
        ItemPrinter.PrintIds(students);

        List<IDescribable> mixedItems = new List<IDescribable>
        {
            books[0],
            courses[0],
            students[0]
        };

        Console.WriteLine("\n=== KARIŞIK LİSTE ===");
        ItemPrinter.PrintDescriptions(mixedItems);
    }
}
