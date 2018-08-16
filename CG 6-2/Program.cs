using System;

namespace CG_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence.");
            string myString = Console.ReadLine();
            myString = myString.ToUpper();
            Console.WriteLine(myString);


            Console.ReadLine();

        }
    }
}
