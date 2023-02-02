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
    internal class Weapon : Clue
    {
        protected int Damage { get; set; }
        protected DamageType DamageType { get; set; }

        public Weapon(string description, string name, RarityType rarity, double value, double weight, int damage, 
            DamageType damageType, bool accuracy, string incriminated) : base(description, name, rarity, value, weight, accuracy, incriminated)
        {
            Damage = damage;
            DamageType = damageType;
        }

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
