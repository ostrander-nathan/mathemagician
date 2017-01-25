using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");
            Console.WriteLine(); // How you provide the user useful info is on you
            // Think about how will the user pick a command?
            // Is it better to modify the orginal question? Make it more useful?

            string command = Console.ReadLine();
            // Once I have the command(whatever it look like) how should i check if its a valid command

            // When should you actually create an instance of your number class? now or later? 
            Console.WriteLine("How many should I print?");
            // When do I check if the "How Many" response is to big?
            // If they enter a number > 30, how do I respond AND exit the program?

            string how_many = Console.ReadLine();

            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
