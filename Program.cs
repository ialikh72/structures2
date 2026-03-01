using System;
class Program
{
    struct Employee

    {
        public string name;
        public double salary;
        public string city;

        public Employee(string n, double s, string c)
        {
            name = n;
            salary = s;
            city = c;
        }
    }

    static void Main()
    {
       Employee emp = new Employee("Ali",60000,"muzaffarabad");
       Employee emp2 = new Employee("akmal", 45000, "karachi");
        Console.WriteLine($"Name{emp.name}, Salary{emp.salary}, City{emp.city}");
        Console.WriteLine($"Name{emp2.name}, Salary{emp2.salary}, City{emp2.city}");
    }
}
