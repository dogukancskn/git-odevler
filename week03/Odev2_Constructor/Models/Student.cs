using System;

namespace Odev2_Constructor.Models;

public class Student
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;
    public string StudentNumber { get; set; } = string.Empty;

    public Student()
    {

    }
    public Student(int id, string fullName, string studentNumber)
    {
        Id = id;
        FullName = fullName;
        StudentNumber = studentNumber;
    }
}
