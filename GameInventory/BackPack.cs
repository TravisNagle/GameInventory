using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class BackPack
    {
        private List<Item> Contents { get; set; }

        public BackPack()
        {
            Contents = new List<Item>();
        }

        public void Add(Item item)
        {
            Contents.Add(item);
        }

        public string ListClues()
        {
            string clueFormat = $"\nClues--------------------------------------------------";
            foreach (Item item in Contents)
            {
                if (item is Clue && !(item is Weapon))
                    clueFormat += $"\n{item}\n";
            }
            return clueFormat;
        }

        public string ListItems()
        {
            string itemList = "";
            itemList += ListClues();
            itemList += ListWeapons();
            return itemList;
        }

        public string ListWeapons()
        {
            string weaponFormat = $"\nWeapons--------------------------------------------------";
            foreach(Item item in Contents)
            {
                if(item is Weapon)
                    weaponFormat += $"\n{item}\n";
            }
            return weaponFormat;
        }
    }
}
