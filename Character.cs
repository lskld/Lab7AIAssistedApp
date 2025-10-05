using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AIAssistedApp
{
    internal class Character
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int HealthPoints { get; set; }
        public string SpecialAbility { get; set; }

        public Character(string name, int strength, int speed, int healthPoints, string specialAbility)
        {
            Name = name;
            Strength = strength;
            Speed = speed;
            HealthPoints = healthPoints;
            SpecialAbility = specialAbility;
        }

         /*
         *AI gave me some tips on how to format the display section for better readability in the console
         *Example: add the ================================ line before every character for good separation.
         */
        public void DisplayCharacter()
        {
            Console.WriteLine(
                $"================================\n" +
                $"Character: {Name}\n" +
                $"Strength: {Strength}\n" +
                $"Speed: {Speed}\n" +
                $"Health: {HealthPoints}\n" +
                $"Special Ability: {SpecialAbility}\n");
        }
    }
}
