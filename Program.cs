using System;

namespace Myfirstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we display some information on the screen
            Console.WriteLine("Hey. How are you?");
            Console.WriteLine();
            //We ask for two numbers we will use in the code later
            Console.WriteLine("Please enter your maximum random value:");
            var maximumRandomValue = int.Parse(Console.ReadLine());            
            Console.WriteLine();
            Console.WriteLine("OK. Great. Would you care to tell me how many time you want me to repeat my trick?");
            var maximumRepeatValue = int.Parse(Console.ReadLine());

            //We use those two numbers to "shape" our Color class
            //and decide how many time we will be displaying its properties
            var myColor = new Color();        
            myColor.Name = "Random";
            for (int currentNumber = 0; currentNumber < maximumRepeatValue; currentNumber++)
            {
                myColor.ChangeRandomValue(maximumRandomValue);

                Console.WriteLine("Here is your new random colors");
                Console.WriteLine();
                Console.WriteLine($"Name={myColor.Name}, Value={myColor.Value}");
            }
        }
    }
}
