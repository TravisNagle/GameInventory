using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class Weapon : Item
    {
        protected int Damage { get; set; }
        protected DamageType DamageType { get; set; }

        public Weapon(string description, string name, RarityType rarity, double value, double weight, int damage, DamageType damageType) : base(description, name, rarity, value, weight)
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
