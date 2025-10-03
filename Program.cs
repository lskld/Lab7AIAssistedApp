//Theo Lilliesköld NET25

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
                DisplayHelper.ShowMenu();
                string userInput = Console.ReadLine();

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
