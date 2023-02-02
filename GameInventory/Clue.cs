///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1 - GameInventory
// Description: Implementation of Clue class that allows for input of accuracy and incrimination of an item
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class Clue : Item
    {
        protected bool Accuracy { get; set; }
        protected string PersonIncriminated { get; set; }

        public Clue(string description, string name, RarityType rarity, 
                    double value, double weight, bool accuracy, string personIncriminated) : base(description, name, rarity, value, weight)
        {
            Accuracy = accuracy;
            PersonIncriminated = personIncriminated;
        }
    }
}
