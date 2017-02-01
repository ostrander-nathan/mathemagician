using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMagician.Numbers;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool hasCommand = true;
            string command = "";
            do
            {
                // Think about how will the user pick a command? Pick Command from question then pick number
                Console.WriteLine("Type in a Command from the following options: NaturalNumber, EvenNumber, OddNumber, FibonacciNumber");
                // Is it better to modify the orginal question? Make it more useful? modified question
                command = Console.ReadLine();
                // When should you actually create an instance of your number class? now or later? 
            } while (command.ToLower() != "naturalnumber" && command.ToLower() != "evennumber" && command.ToLower() != "oddnumber" && command.ToLower() != "fibonaccinumber");
            NaturalNumber userNumber = new NaturalNumber();
                // Once I have the command(whatever it look like) how should i check if its a valid command
                switch (command.ToLower())
                {
                    case "naturalnumber":
                        userNumber = new NaturalNumber();
                        //hasCommand = true;
                        break;

                    case "evennumber":
                        userNumber = new EvenNumber();
                        //hasCommand = true;
                        break;

                    case "oddnumber":
                        userNumber = new OddNumber();
                        //hasCommand = true;
                        break;
                    case "fibonaccinumber":
                        userNumber = new FibonacciNumber();
                        //hasCommand = true;
                        break;
                    //case "primenumber":
                    //    userNumber = new PrimeNumber();
                    //    break;

                    default:
                        Console.WriteLine("Whoops! Wrong Command");
                        break;
                        // Need Command to go back to start 
                }
            int number = 0;
            do
            {
                Console.WriteLine("How many should I print 1-30?");
                string how_many = Console.ReadLine();
                number = Int32.Parse(how_many);// set string input(how_many) to int number
            } while (!(number <= 30 && number >= 1));
            if (number <= 30 && number >= 1)// if statement to determine if number is in between the 1-30
            {
                Console.WriteLine($"Cool, I'm going to print {number} {command} numbers.");
                // set userNumber with method PrintNumbers and parameter calling GetSeq w/number value
                string entirePrintOut = userNumber.PrintNumbers(userNumber.GetSequence(number));
                Console.WriteLine(entirePrintOut);
            }
            else
            {
                // If they enter a number > 30, how do I respond AND exit the program?
                // When do I check if the "How Many" response is to big?
                Console.WriteLine($"Enter a number less than 30");
            };

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
