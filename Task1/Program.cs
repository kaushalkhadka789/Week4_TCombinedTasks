using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== TASK 1 ==========");

        // Task 1: Class, Objects & Fields
        Student s1 = new Student();
        s1.name = "Kaushal";
        s1.age = 22;
        s1.course = "Computing";

        Student s2 = new Student();
        s2.name = "Suman";
        s2.age = 21;
        s2.course = "Cyber Security";

        Console.WriteLine($"Student 1: {s1.name}, {s1.age}, {s1.course}");
        Console.WriteLine($"Student 2: {s2.name}, {s2.age}, {s2.course}");
        Console.WriteLine("College: " + Student.college);

    }
}