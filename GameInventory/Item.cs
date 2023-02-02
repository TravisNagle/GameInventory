﻿///////////////////////////////////////////////////////////////////////////////
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
    internal class Item
    {
        protected string Description { get; set; }
        protected string Name { get; set; }
        protected RarityType Rarity { get; set; }
        protected double Value { get; set; }
        protected double Weight { get; set; }

        public Item(string description, string name, RarityType rarity, double value, double weight)
        {
            Description = description;
            Name = name;
            Rarity = rarity;
            Value = value;
            Weight = weight;
        }

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
