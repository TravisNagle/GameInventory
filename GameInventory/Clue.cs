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
    /// <summary>
    /// Implementation of the Clue class that inherits from the Item class
    /// </summary>
    internal class Clue : Item
    {
        protected bool Accuracy { get; set; }
        protected string PersonIncriminated { get; set; }

        /// <summary>
        /// Parameterized constructor that creates a new Clue object given the parameters
        /// </summary>
        /// <param name="description">Description of the clue</param>
        /// <param name="name">The clue's name</param>
        /// <param name="rarity">The rarity value of the clue</param>
        /// <param name="value">The possible value of a clue</param>
        /// <param name="weight">The weight of the clue</param>
        /// <param name="accuracy">If the clue is accurate</param>
        /// <param name="personIncriminated">Who the clue incriminates</param>
        public Clue(string description, string name, RarityType rarity, 
                    double value, double weight, bool accuracy, string personIncriminated) : base(description, name, rarity, value, weight)
        {
            Accuracy = accuracy;
            PersonIncriminated = personIncriminated;
        }
    }
}
