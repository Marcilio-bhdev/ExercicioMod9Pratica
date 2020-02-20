using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioMod9Pratica.Entities.Enums;
using ExercicioMod9Pratica.Entities;

namespace ExercicioMod9Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());



        }
    }
}
