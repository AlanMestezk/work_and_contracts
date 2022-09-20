

using System;
using Course.Entities;
using Course.Entities.Enums;

using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("     Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("            Enter worker date ");
            Console.Write("            Name: ");
            string name = Console.ReadLine();
            Console.Write("            Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("            Base Salary: ");
            double baseSalaray = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new (name, level, baseSalaray, dept);

            Console.WriteLine();
            Console.WriteLine("      Enter how many contracts");
            Console.Write("          will be for this worker: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine($"        Enter #{i} contract data ");
                Console.Write("                 Date (DD/MM/YY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("                     Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                Console.Write("                     Durations (hours): ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine();

                HourContratct contratct = new (date, valuePerHour, hours);

                worker.AddContract(contratct);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("       Enter month and year to calcule income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}
