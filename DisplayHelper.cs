using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AIAssistedApp
{
    internal class DisplayHelper
    {
        //AI gave the idea to keep ShowMenu as a separate method to improve readability in Main method.
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to the *MAGIC* character creation program. Please choose how to proceed:");
            Console.WriteLine("1. Generate a new character");
            Console.WriteLine("2. Show all characters");
            Console.WriteLine("3. Exit Program");
            Console.Write("\nEnter your choice: ");
        }
    }
}
