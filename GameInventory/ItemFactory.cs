using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class ItemFactory
    {
        public Clue MakeRandomClue()
        {
            return null;
        }

        public Clue MakeRandomClue(bool isAccurate, string inciminate)
        {
            return null;
        }

        public Item MakeRandomItem()
        {
            return null;
        }

        public Weapon MakeRandomWeapon(RarityType rarity)
        {
            return null;
        }

        public Weapon MakeRandomWeapon(RarityType rarity, bool isAccurate, string incriminate)
        {
            return null;
        }
    }
}
