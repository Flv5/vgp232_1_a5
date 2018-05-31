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
            mWeapons.Capacity = maxWeaponCount;
            mPotions.Capacity = maxPotionCount;

            mPotionIndex = 0;
            mWeaponIndex = 0;
        }

        void InsertPotion(Potion potion)
        {
            if (mPotions.Capacity < mMaxPotionCount)
            {
                mPotions.Insert(mPotionIndex, potion);
                ++mPotionIndex;
            }
            else
                Console.WriteLine("Not enough space for potions");
        }

        void InsertWeapon(Weapon weapon)
        {
            if (mWeapons.Capacity < mMaxWeaponCount)
            {
                mWeapons.Insert(mWeaponIndex, weapon);
                ++mWeaponIndex;
            }
            else
                Console.WriteLine("Not enough space for weapons");
        }
    }
}
