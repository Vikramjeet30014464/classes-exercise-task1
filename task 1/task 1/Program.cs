using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 2*/
            person Vikram = new person("Vikram", "Singh", 21);
            Console.WriteLine("Person's Details");
            Console.WriteLine($"Name: {Vikram.Fname} {Vikram.Lname}\nAge: {Vikram.Age}");
            string fname, lname;
            int age;
            fname = Console.ReadLine();
            lname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            person vikram = new person(fname, lname, age);
        }
    
      
    }
}
        
