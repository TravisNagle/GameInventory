///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1 - GameInventory
// Description: Implementation of Item class that serves as a template for all items
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
    /// Implementation of the Item class that creates objects to fill the backpack
    /// </summary>
    internal class Item
    {
        protected string Description { get; set; }
        protected string Name { get; set; }
        protected RarityType Rarity { get; set; }
        protected double Value { get; set; }
        protected double Weight { get; set; }

        /// <summary>
        /// Paramaterized constructor that is used to create different base parameters
        /// for the Weapon and Clue subclasses
        /// </summary>
        /// <param name="description">Description of the item</param>
        /// <param name="name">Name of the item</param>
        /// <param name="rarity">Rarity value of the item</param>
        /// <param name="value">Monetary value of the item</param>
        /// <param name="weight">Weight of the item</param>
        public Item(string description, string name, RarityType rarity, double value, double weight)
        {
            Description = description;
            Name = name;
            Rarity = rarity;
            Value = value;
            Weight = weight;
        }

        /// <summary>
        /// Converts Item to a string and checks for rarity value
        /// to set rarity's greater than COMMON as the prefix to the item name
        /// </summary>
        /// <returns>Item as a string listed vertically</returns>
        public override string ToString()
        {
            string info = "";
            if (Rarity != RarityType.COMMON)
            {
                info += $"Item Name: {Rarity} {Name}";
            }
            else
            {
                info += $"Item Name: {Name}";
            }

            info += $"\nDescription: {Description}";
            info += $"\nWeight: {Weight} pounds";
            info += $"\nValue: ${Value}";
            return info;
        }
    }
}
