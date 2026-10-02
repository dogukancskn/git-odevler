using Odev2_Constructor.Models;

namespace Odev2_Constructor;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1, "Doğukan Coşkun", "123");
        Student s2 = new Student(2, "Volkan Coşkun", "321");

        Student s3 = new Student();
        s3.Id = 3;
        s3.FullName = "Ayşe";
        s3.StudentNumber = "456";


        Student s4 = new()
        {
            Id = 4,
            FullName = "Ensar Şahin",
            StudentNumber = "654"
        };
    }
}
