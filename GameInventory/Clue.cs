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
