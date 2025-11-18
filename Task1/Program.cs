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

        Console.WriteLine("\n========== TASK 2 ==========");

        // Task 2: Methods
        Calculator calc = new Calculator();
        calc.PrintWelcome();
        Console.WriteLine("Add: " + calc.Add(10, 20));
        Console.WriteLine("Multiply default: " + calc.Multiply(5));
        Console.WriteLine("Multiply(5,3): " + calc.Multiply(5, 3));

        Console.WriteLine("\n========== TASK 3 ==========");

        // Task 3: Parameter Types
        ParameterDemo pd = new ParameterDemo();

        int number = 20;
        pd.Increase(ref number);
        Console.WriteLine("Increase(ref): " + number);

        pd.GetFullName(out string fname);
        Console.WriteLine("Full name: " + fname);

        Console.WriteLine("SumAll: " + pd.SumAll(1, 2, 3, 4, 5));

        Console.WriteLine("\n========== TASK 4 ==========");

        // Task 4: Constructors
        Player p1 = new Player();   // default
        Player p2 = new Player("Archer", 5, 100); // parameterized
        Console.WriteLine($"{p2.playerName}, {p2.level}, {p2.health}");

        Console.WriteLine("\n========== TASK 5 ==========");

        // Task 5: Enum and Record
        Console.Write("Enter day: ");
        string day = Console.ReadLine().ToLower();

        DayType type = (day == "friday" || day == "saturday")
                        ? DayType.Weekend : DayType.Weekday;

        Console.WriteLine("It is: " + type);

        Book b1 = new Book("C# Basics", "ABC", 1000);
        Book b2 = b1 with { title = "Advanced C#", price = 1300 };

        Console.WriteLine("Book 1: " + b1);
        var (t, a, p) = b2;
        Console.WriteLine($"Book 2: {t}, {a}, {p}");

        Console.WriteLine("\n========== TASK 6 ==========");
        //Task6 is about debugging and check for the percentage calculation
        Console.Write("Enter marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        int.TryParse(Console.ReadLine(), out int total);

        double percentage = (double)marks / total * 100;

        Console.WriteLine("Percentage = " + percentage);



    }
}