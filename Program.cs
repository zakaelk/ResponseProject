using System;
namespace ResponseProject;
class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            string name;
            int age;

            Console.WriteLine("Welcome! What is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, what is your age?");
            var ageResponse = Console.ReadLine();
            age = Convert.ToInt32(ageResponse);

            switch (age)
            {
                case var myAge when myAge < 18:
                Console.WriteLine("You are too young to be playing this game, go home.");
                break;

                case var myAge when myAge < 70 && myAge >= 17:
                Console.WriteLine("Thanks for entering you information");
                break;

                case var myAge when myAge >= 70:
                Console.WriteLine("You are very old no offense");
                break;
                default:
                Console.WriteLine("How did you get this response?");
                break;
            }
            
            Console.WriteLine("Do you want to run this again?");
            string isRunningResponse = Console.ReadLine();
            if(isRunningResponse == "no")
            {
                isRunning = false;
            }
        }
    }
}