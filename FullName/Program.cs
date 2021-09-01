using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {

            //Step 1. programm küsib kasutaja käest eesnime
            //Step 2. programm küsib kasutaja läest kasutaja perekonnanime
            //Step 3. programm tervitab kasutajat kasutades naeidandmeid


            Console.WriteLine("Hello What Is Your Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Okay,But what is your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine($"hello, {FirstName} {surname}");




        }
    }
}
