using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string userLastname = Console.ReadLine();
            //lisa perekonnanimi
            Greetings(userName, userLastname, userAge);

        }

        private static void Greetings (string someString, string anoyherString, int someInt)
        {
            //lisa perekonnanimi
            Console.WriteLine($"Tere, {someString} {anoyherString}!");
            Console.WriteLine($"Oled {2021 - someInt}.");
        }
    }
}
