using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            string movie4 = "The Super Mario Bros. Movie(PG)";
            string movie5 = "Blue Beetle(12)";

            
            Console.WriteLine($"Which movie would you like to watch? (enter number) \n(1) {movie1} \n(2) {movie2} \n(3) {movie3}\n(4) {movie4}\n(5) {movie5}.");
          

            moviechoice = int.Parse(Console.ReadLine());
            if(moviechoice > 5)

            {
                Console.WriteLine("Invalid Movie choice");
            }
  

                Console.WriteLine("How old are you?");
            

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

            if (moviechoice == 4 && age < 8)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 4 && age >= 8)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }

            if (moviechoice == 5 && age < 12)
            {
                Console.WriteLine("You are too young!");
            }

            if (moviechoice == 5 && age >= 12)

            {
                Console.WriteLine("Ok, How many people are watching?");
            }
            
            int people = int.Parse(Console.ReadLine());

            if (people <= 0 | people >6) 
            {
               Console.WriteLine("Invalid amount of People!");
            }
            if (people >= 1 && people <= 6) 
            //booking date
            {
                Console.WriteLine("Okay, What date would you like to book it? (DD/MM/YYYY)");
            }
            DateTime dateTime = DateTime.Now;

            DateTime bookingdate = DateTime.Parse(Console.ReadLine());

            if (bookingdate > dateTime) 
            {
              //ticket
                Console.WriteLine($"Okay, Please enjoy!\n-------------------\n Aquinas Multiplex\n Film: {moviechoice}\n Date: {bookingdate}\n Amount: {people}\n-------------------");          
            }
            if (bookingdate<= dateTime)
            {
                Console.WriteLine("Invalid Date!");
            }
            Console.ReadLine();




        }

    }
}


