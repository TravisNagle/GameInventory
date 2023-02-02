///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1 - GameInventory
// Description: Implementation of the BackPack class that can store a list of items and display them
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    /// <summary>
    /// Implementation of the BackPack class that stores Item values to a list
    /// </summary>
    internal class BackPack
    {
        private List<Item> Contents { get; set; }

        /// <summary>
        /// Default constructor that creates a new empty list
        /// </summary>
        public BackPack()
        {
            Contents = new List<Item>();
        }

        /// <summary>
        /// Add method that adds the input into the Contents list
        /// </summary>
        /// <param name="item">Inputted item</param>
        public void Add(Item item)
        {
            Contents.Add(item);
        }

        /// <summary>
        /// Displays all Clue items in the list
        /// </summary>
        /// <returns>String of all clues</returns>
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

        /// <summary>
        /// Displays all the items in the list
        /// </summary>
        /// <returns>String of all items</returns>
        public string ListItems()
        {
            string itemList = "";
            itemList += ListClues();
            itemList += ListWeapons();
            return itemList;
        }

        /// <summary>
        /// Displays all the weapons in the list
        /// </summary>
        /// <returns>String of all weapons</returns>
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
