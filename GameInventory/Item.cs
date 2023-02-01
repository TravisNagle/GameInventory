﻿using System;
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
            return base.ToString();
        }
    }
}