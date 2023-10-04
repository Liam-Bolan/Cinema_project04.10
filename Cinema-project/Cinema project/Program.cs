using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _21._09._23_strings_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moviechoice;
            int age;
            string movie1 = "Oppenheimer (R)";
            string movie2 = "Thor: Love and Thunder(12)";
            string movie3 = "Strays (15)";
            string movie4 = "";
            string movie5 = "";


            Console.WriteLine($"Which movie would you like to watch? (1) {movie1}, (2) {movie2}, (3) {movie3}, (4) {movie4}, (5) {movie5},");
           try
            {
                moviechoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Movie choice");
            }

            moviechoice = int.Parse(Console.ReadLine());
            if (moviechoice > 5)

            {
                Console.WriteLine("Invalid Movie choice");
            }
            else

                Console.WriteLine("How old are you?");
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid age!");
            }

            age = int.Parse(Console.ReadLine());
            if (moviechoice == 1 && age < 18)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 1 && age >= 18)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }

            if (moviechoice == 2 && age < 12)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 2 && age >= 12)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }
            if (moviechoice == 3 && age < 15)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 3 && age >= 15)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }

            if (moviechoice == 4 && age < 2)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 4 && age >= 2)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }

            if (moviechoice == 5 && age < 2)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 5 && age >= 2)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }
            
            int people = int.Parse(Console.ReadLine());




            Console.ReadLine();




        }

    }
}


