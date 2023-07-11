using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            DateTime doj;
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter DOJ");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID\t Employee Name\t Employee Gender\t Employee Salary\t DOJ\n" +
                "-------------------------------------------------------------------------------\n" +
                id+"\t"+name+"\t\t"+gender+"\t\t\t\t"+salary+"\t\t\t"+doj);
            if (salary > 90000)
            {
                Console.WriteLine("you have to pay 30% tax ");
            }
            else
            {
                Console.WriteLine("tax will be 15%");
            }
            Console.ReadKey();


        }
    }
}
