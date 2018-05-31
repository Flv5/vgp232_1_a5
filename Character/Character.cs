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
        String mName;
        String mGender; 
        int healthPoints;
        Races race;
        Alignments alignment;
        public Character(int hp, Races r, Alignments a, String name, String gender)
        {
            mName = name;
            mGender = gender;
            healthPoints = hp;
            race = r;
            alignment = a;
        }
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
        }

        public void TakeDamage(int damage)
        {
            healthPoints -= damage;
        }

        public void RestoreHealth(int amount)
        {
            healthPoints += amount;
        }
    }
}
