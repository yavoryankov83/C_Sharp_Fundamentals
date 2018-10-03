using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name} \nAge: {age} \nEmployee ID: {id:D8} \nSalary: {salary:F2}");
        }
    }
}
