using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("cat", "meauu");
           
            Console.WriteLine($"Animal Details are: {a1.Details()}");
            Console.ReadLine();
        }
        class Animal
        { //Attributes
            string type;
            string name;
            int id;
            //Attributes getter and setter//
            public string Type { get { return type; } set { type = value; } }
            public string Name { get { return name; } set { name = value; } }
            private int Id { get { return id; } set { id = value; } }
            // Constructor//
            public Animal(string _type, string _name)
            {
                Type = _type;
                Name = _name;
                Id = RandomId();
            }
            //method//
            private int RandomId()
            {
                Random rand = new Random();
                return rand.Next(1000, 9999);
            }
            public string Details()
            { return $"Type:{Type}\nName:{Name}\n ID: {Id}"; }
        }
                
    }
}
