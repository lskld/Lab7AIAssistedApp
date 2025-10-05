//Theo Lilliesköld NET25

     /*
     * The AI that has been used: Claude Sonnet 4.5 via Github CoPilot
     * AI has assisted with the entire structure of the program.
     * AI has assisted with which classes are needed.
     * AI has also helped give ideas for which methods that should be used.
     */

namespace Lab7AIAssistedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var characterList = new List<Character>();
            bool exit = false;

            while (!exit)
            {
                //Start with showing the menu selections, and wait for users input. 
                DisplayHelper.ShowMenu();
                string? userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        characterList.Add(CharacterGenerator.CreateCharacter());
                        Console.WriteLine("A new character has successfully been added to the list. Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        if(characterList.Count == 0)
                        {
                            Console.WriteLine("No characters have been created.");
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else { 
                            foreach (Character character in characterList)
                            {
                                character.DisplayCharacter();
                            }
                            Console.WriteLine("Press any key to go back to main menu...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Program is now shutting down...");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Wrong input, choose 1, 2 or 3");
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
