using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Employee #" + i);
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("---------------------------------");

                employeeList.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the ID of the employee who will receive a salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percentage: ");
            double increasePercentage = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            
            Employee employeeReceivingSalaryIncrease = employeeList.Find(x => x.Id == idSalaryIncrease);

            employeeReceivingSalaryIncrease.Salary += employeeReceivingSalaryIncrease.Salary * (increasePercentage / 100);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Last updated list of employees:\n");
            

            foreach(Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine("----------------------------------------");




        }
    }
}
