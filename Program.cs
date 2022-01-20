using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enployers20012022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many enployees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            List<Enployeer> list = new List<Enployeer>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enployer # {i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Enployeer(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the Employeers Id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Enployeer emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Employeers List Updated:");
            foreach (Enployeer obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
