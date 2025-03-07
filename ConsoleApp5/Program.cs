using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Джон", "Бертс", 32);
            person.Output();
            Console.WriteLine($"\n");
            Employee employee = new Employee("Джезев", "Бе", 58, "A-Codex", "Web Developer");
            employee.Output();
            Console.WriteLine($"\n");
            Person employeeAsPerson = new Employee("Марк", "Цукерберк", 43, "A-Codex", "Web Developer");
            employeeAsPerson.Output();
            Console.ReadKey();
        }
    }
}
