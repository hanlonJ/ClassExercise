using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            try
            {
                string input = Console.ReadLine();
                Recommend_Name(input);
            } // End of try
            catch
            {
                Console.WriteLine("There was a problem processing that input...");
                Console.WriteLine("Please press any key to exit the program and try again...");
                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true);
            } // End of catch
        } // End of main
        private static void Recommend_Name(string get_name)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + get_name + "!");
            Console.ReadKey(true);
        } // End of Recommend_Name
    } // End of class
   } // End of namespace


