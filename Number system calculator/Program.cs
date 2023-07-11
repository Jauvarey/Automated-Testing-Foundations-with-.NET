using System;
using System.Data;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            bool EndApp = false;
            Console.WriteLine("Welcome in \"Number system\"!");
            Console.WriteLine("=============================");

            while (!EndApp)
            {
                Console.WriteLine("Enter an integer number");
                string intInDecimal = Console.ReadLine();
                bool negative = false;
                int a = 0;
                int b = 0;
           
                while (!int.TryParse(intInDecimal, out a))
                {
                    Console.WriteLine("Enter an intenger number");
                    intInDecimal = Console.ReadLine();

                }
                if (a < 0)
                {
                    a = a * -1;
                    negative = true;

                }
           

                Console.WriteLine("Enter a base of number system!");
                string baseOfNumberSystem = Console.ReadLine();
            
                while (!int.TryParse(baseOfNumberSystem, out b) || (int.Parse(baseOfNumberSystem) < 2) | (int.Parse(baseOfNumberSystem) > 20))
                {
                    Console.WriteLine("Enter an intenger number, from 2 till 20");
                    baseOfNumberSystem = Console.ReadLine();
                
                }

            
            
                string output = Computation( b, a);
                if (negative)
                {
                    output = ("-" + output);
                }

                Console.WriteLine(output);
                Console.WriteLine("==================\n");
                Console.WriteLine("If you want to try again press 'Enter', or press 'c' to close app!");
                if (Console.ReadLine() == "c") EndApp = true;

            }
        }

         static string Computation(int b, int a)
        {
            string number = "";
            int d = a % b;
            int c = a / b;
            string[] letters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "I", "J", "K" };

            
            if (c == 0)
            {
                number = (letters[d]);
            }


            while (c != 0)
            {
                number = (letters[d]+number);
                d = c % b;
                c = c / b;
                
                if (c == 0)
                {
                    number = (letters[d]+number);
                    break;
                }
            }

            return number;
        }

    }
}




