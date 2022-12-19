using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Get_Middle(input);



        }

        static string Get_Middle(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input.Substring((input.Length / 2) - 1, 2));
                return input;
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
                return input;
            }





        }




    }
    }

