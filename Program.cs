using System;
namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program identifies a prime number.
            Console.WriteLine("THIS PARTICULAR CONSOLE APPLICATION IDENTIFIES A PRIME NUMBER\n");

            //output_texts
            string True = "this IS A prime number";
            string False = "this IS NOT A prime number";

            // take raw input from user
            Console.Write("Please input in your integer (must be an integer): ");
            string rawInput = Console.ReadLine();

            //test input for correctness. INPUT MUST BE AN INTEGER TYPE
            int cleanedInput;
            bool testInput = int.TryParse(rawInput, out cleanedInput);

            if (!testInput)
            {
                Console.WriteLine("INVALID INPUT!. (Input has to be an integer type!)");
            }
            else
            {
                if (cleanedInput==1)
                {
                    Console.WriteLine(False);
                }
                else if (cleanedInput==2)
                {
                    Console.WriteLine(True);
                }
                else
                {
                    for (double i = 2; i < cleanedInput; i++)
                    {
                        if ((cleanedInput%i) == 0)
                        {
                            Console.WriteLine(False);
                            break;
                        }
                        else
                        {
                            if (i == (cleanedInput - 1))
                            {
                                Console.WriteLine(True);
                            }
                        }
                    }
                }
            }
        }
    }
}