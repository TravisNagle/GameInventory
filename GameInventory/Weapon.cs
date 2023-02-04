///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1 - GameInventory
// Description: Implementation of a weapon class that allows for damage values and damage types
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
    /// Implementation of the Weapon class that addes damage and damage type
    /// to the Item/Clue parent class
    /// </summary>
    internal class Weapon : Clue
    {
        protected int Damage { get; set; }
        protected DamageType DamageType { get; set; }

        /// <summary>
        /// Parameterized constructor that allows for the input of damage and damage
        /// type values to separate from the Clue objects in the BackPack lists
        /// </summary>
        /// <param name="description">Description of the weapon</param>
        /// <param name="name">Name of the weapon</param>
        /// <param name="rarity">Rarity value of the weapon</param>
        /// <param name="value">Monetary value of the weapon</param>
        /// <param name="weight">Weight of the weapon</param>
        /// <param name="damage">The number of hit points the weapon deals</param>
        /// <param name="damageType">What type of damage the weapon deals</param>
        /// <param name="accuracy">If the weapon is an accurate clue</param>
        /// <param name="incriminated">Which person this weapon incriminates</param>
        public Weapon(string description, string name, RarityType rarity, double value, double weight, int damage, 
            DamageType damageType, bool accuracy, string incriminated) : base(description, name, rarity, value, weight, accuracy, incriminated)
        {
            Damage = damage;
            DamageType = damageType;
        }

        /// <summary>
        /// Converts Weapon to a string with DamageType and Damage
        /// values listed vertically
        /// </summary>
        /// <returns>Weapon as a string</returns>
        public override string ToString()
        {
            string info = "";
            info += base.ToString();
            info += $"\nDamage Type: {DamageType}";
            info += $"\nDamage Dealt: {Damage} health points";
            return info;
        }
    }
}
