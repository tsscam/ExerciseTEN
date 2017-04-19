using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            double height = 54;
            double sentence;
            double difference;
            string result;
            

            do
            {
                Console.WriteLine("How Tall Are you!");
                sentence = double.Parse(Console.ReadLine());

                if (sentence <= height)
                {
                    Console.WriteLine("Sorry, but you are not tall enought");
                    
                    difference = height - sentence;
                    Console.WriteLine("Sorry, you cannot ride the Raptor. You need {0} more inches", difference);

                }
                Console.WriteLine("Would you like to Continue: Select Y/N: ");
                result = Console.ReadLine();
                if ((result.ToLower() == "no") || (result.ToLower() == "n"))
                    run = false;

            }
            while (run);
        }
    }
}





