using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Listas
{
    public class Employee
    {
        //Atributos
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employee(int id, string name, double salary) 
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

    
        //ToString

        public override string ToString()
        {
            return "The employee " + Name + " with ID: " + Id + " receive US$" + Salary + " per month.";
        }
    }
}
