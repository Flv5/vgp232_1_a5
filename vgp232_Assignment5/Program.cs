using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;
using PersistentData;
using Character;
using Inventory;
namespace vgp232_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Systems...");
            // TODO: create inventory system
            Inventory.Inventory inventory = new Inventory.Inventory(5);

            Item item = new Item("A", 1, ItemType.consumable);
            Item item2 = new Item("B", 2, ItemType.consumable);
            Item item3 = new Item("C", 3, ItemType.consumable);
            Item item4 = new Item("D", 4, ItemType.consumable);

            inventory.Add(item);
            inventory.Add(item2);
            inventory.Add(item3);
            inventory.Add(item4);

            Console.WriteLine("Initializing Character Manager");
            Character.Character player;

            // load the character
            player = PersistentData.PersistentData.Deserialize<Character.Character>("player.xml");
            if (player == null)
            {
                Console.WriteLine("No player found, creating new default character");
                player = new Character.Character(100, Races.Elf, Alignments.Neutral);
            }

            CharacterManager characterManager = CharacterManager.Instance;
            characterManager.Player = player;
            Character.Character enemyOne = new Character.Character(50, Races.Orc, Alignments.ChaoticEvil, "1", "masculine");
            Character.Character enemyTwo = new Character.Character(50, Races.Orc, Alignments.NeutralEvil, "2", "masculine");
            characterManager.AddEnemy(enemyOne);
            characterManager.AddEnemy(enemyTwo);

            // TODO: create persistent data system

            // save the player
            Console.WriteLine("Saving player");
            PersistentData.PersistentData.Serialize<Character.Character>(player, "character.xml");

            Console.WriteLine("Press return to exit...");
            Console.ReadKey();
        }
    }
}
