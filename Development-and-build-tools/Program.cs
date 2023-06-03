using System;

namespace smart
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome in my s-smart program \"Long Word\"\n");
                Console.WriteLine("===========================================\n");

                Console.WriteLine("Write the longest word, you know!");
                string word = "";
                word = (Console.ReadLine());

                int quontityOfDifChar = 0;

                string symbolOrder = "";
                
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] != word[i+1])
                    {
                        symbolOrder = symbolOrder + word[i];
                        quontityOfDifChar++;
                    }
                    else
                    {
                        symbolOrder += word[i];
                        quontityOfDifChar++;
                        break;
                    }
                    if (i == word.Length - 2)
                    {
                        symbolOrder = symbolOrder + word[i + 1];
                        quontityOfDifChar++;
                    }

                
                }
                
                Console.WriteLine(symbolOrder);
                Console.WriteLine($"Your result is {quontityOfDifChar} ");
                Console.ReadKey();
           
            }
        }
}



