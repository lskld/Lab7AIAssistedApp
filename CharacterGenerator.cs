using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AIAssistedApp
{
    internal class CharacterGenerator
    {
        private static Random rand = new Random(); //Fixed with the help of AI, tried to initiate using "var" or only Random rand = new Random();

        private static List<string> nameList = new List<string>
        {
           "Thorin Ironforge", "Lyra Moonwhisper", "Zephyr Stormborn",
            "Raven Nightshade", "Aldric Flameheart", "Seraphina Starweaver",
            "Garrick Stonefist", "Elara Frostwind", "Draven Shadowblade",
            "Aria Silvermoon", "Theron Wildfire", "Nyx Darkwater",
            "Magnus Thunderstrike", "Isolde Dawnsinger", "Kael Bloodraven",
            "Freya Iceborn", "Varian Ashenblade", "Celeste Lighthaven",
            "Ragnar Steelbreaker", "Morgana Voidwalker"
        };
        private static List<string> abilityList = new List<string>
        {
            "Fireball", "Shadow Step", "Divine Shield", "Lightning Strike",
            "Frost Nova", "Berserker Rage", "Healing Touch", "Invisibility",
            "Meteor Shower", "Blood Drain", "Earthshatter", "Wind Slash",
            "Time Warp", "Poison Cloud", "Holy Smite", "Dark Resurrection",
            "Arcane Blast", "Stone Skin", "Teleportation", "Flame Burst"
        };

        public static Character CreateCharacter()
        {
            var newCharacter = new Character(GenerateName(), RandomNumberGenerator(10, 101), RandomNumberGenerator(5, 51), RandomNumberGenerator(100, 1001), GenerateAbility());
            return newCharacter;
        }

        private static int RandomNumberGenerator(int min, int max)
        {
            return rand.Next(min, max);
        }
        private static string GenerateName()
        {
            return nameList[RandomNumberGenerator(0, nameList.Count)];
        }
        private static string GenerateAbility()
        {
            return abilityList[RandomNumberGenerator(0, abilityList.Count)];
        }
    }
}
