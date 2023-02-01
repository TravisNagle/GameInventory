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
            Random rand = new Random();
            int randomValue = rand.Next(0, 5);

            Clue clue = new Clue("", "", RarityType.COMMON, -1, -1, false, "");

            return clue;
        }

        public Clue MakeRandomClue(bool isAccurate, string inciminate)
        {
            return null;
        }

        public Item MakeRandomItem()
        {
            Random rand = new Random();
            int newItemChoice = rand.Next(1, 11);
            Item item;
            if(newItemChoice % 2 == 0 && newItemChoice <= 5)
            {
                item = MakeRandomWeapon(RarityType.COMMON);
            }
            else if(newItemChoice % 2 == 0 && newItemChoice > 5)
            {
                item = MakeRandomWeapon(RarityType.RARE);
            }
            else
            {
                item = MakeRandomClue();
            }

            return item;
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
