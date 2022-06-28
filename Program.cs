using System;
using System.Globalization;

namespace ExerciseClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee p1, p2;
            p1 = new Employee();
            p2 = new Employee();

            Console.WriteLine("Insira os dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira os dados da Segunda pessoa");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Avg = (p1.Salary + p2.Salary) / 2.0;

            Console.WriteLine("Salario Média " + Avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
