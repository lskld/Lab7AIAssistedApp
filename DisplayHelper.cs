using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AIAssistedApp
{
    internal class DisplayHelper
    {
        //Show the menu
        //Format character output in a nice way
        //Handle user input validation

        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to the *MAGIC* character creation program. Please choose how to proceed:");
            Console.WriteLine("1. Generate a new character");
            Console.WriteLine("2. Show all characters");
            Console.WriteLine("3. Exit Program");
        }
    }
}
