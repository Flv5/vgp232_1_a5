using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public enum Weapon { Knife, Bow, Axe, Sword, Wand }
    public enum Potion { Health_Full, Health_Standar, Magic_Full, Magic_Standar }

    public class Inventory
    {
        List<Weapon> mWeapons;
        List<Potion> mPotions;
        int mPotionIndex;
        int mWeaponIndex;

        int mMaxWeaponCount;
        int mMaxPotionCount;
        public Inventory(int maxWeaponCount, int maxPotionCount)
        {
            mWeapons = new List<Weapon>(maxWeaponCount);
            mPotions = new List<Potion>(maxPotionCount);

            mPotionIndex = 0;
            mWeaponIndex = 0;
        }

        public void InsertPotion(Potion potion)
        {
            if (mPotions.Count < mPotions.Capacity)
            {
                mPotions.Insert(mPotionIndex, potion);
                ++mPotionIndex;
            }
            else
                Console.WriteLine("Not enough space for potions");
        }

        public void InsertWeapon(Weapon weapon)
        {
            if (mWeapons.Count < mWeapons.Capacity)
            {
                mWeapons.Insert(mWeaponIndex, weapon);
                ++mWeaponIndex;
            }
            else
                Console.WriteLine("Not enough space for weapons");
        }

        public void RemovePotion(Potion potion)
        {
            mPotions.Remove(potion);
            --mPotionIndex;
        }

        public void RemoveWeapon(Weapon weapon)
        {
            mWeapons.Remove(weapon);
            --mWeaponIndex;
        }
    }
}