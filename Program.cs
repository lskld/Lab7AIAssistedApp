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
                        Console.ReadLine();
                        Console.Clear();
                        //Generate character method
                        break;
                    case "2":
                        foreach(Character character in characterList)
                        {
                            character.DisplayCharacter();
                        }
                        Console.WriteLine("Press any key to go back to main menu...");
                        Console.ReadLine();
                        Console.Clear();
                        //Show all characters method
                        break;
                    case "3":
                        Console.WriteLine("Program is now shutting down...");
                        exit = true;
                        break;
                }
            }
        }
    }
}
