using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character 
{
    public enum Races { Dwarf, Elf, Goblin, Giant, Halfling, Orc, Vampires, Werewolf, Sphinx }
    public enum Alignments { LawfulGood, LawfulNeutral, LawfulEvil, NeutralGood, Neutral, NeutralEvil, ChaoticGood, ChaoticNeutral, ChaoticEvil }

    public class Character
    {
<<<<<<< HEAD
        String mName;
        String mGender; 
        int healthPoints;
        Race race;
        Alignment alignment;
        public Character(int hp, Race r, Alignment a, String name, String gender)
        {
            mName = name;
            mGender = gender;
            healthPoints = hp;
            race = r;
            alignment = a;
=======
        public int HealthPoints
        {
            get; set;
        }

        public Races Race
        {
            get; set;
        }

        public Alignments Alignment
        {
            get; set;
        }

        public Character()
        {

        }

        public Character(int hp, Races r, Alignments a)
        {
            HealthPoints = hp;
            Race = r;
            Alignment = a;
>>>>>>> WIP_PersistentData
        }

        public void TakeDamage(int damage)
        {
<<<<<<< HEAD
            healthPoints -= damage;
=======
            HealthPoints -= 1;
>>>>>>> WIP_PersistentData
        }

        public void RestoreHealth(int amount)
        {
<<<<<<< HEAD
            healthPoints += amount;
=======
            HealthPoints += 1;
>>>>>>> WIP_PersistentData
        }
    }
}
