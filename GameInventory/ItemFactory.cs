///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1 - GameInventory
// Description: Class that handles random item generation
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class ItemFactory
    {
        public Clue MakeRandomClue()
        {
            Random rand = new Random();
            int randomValue = rand.Next(0, 5);

            Clue clue = new Clue("", "", RarityType.COMMON, -1, -1, false, "");

            switch(randomValue)
            {
                case 0:
                    clue = new Clue("A conspicuous note", "Note", RarityType.COMMON, 1.50, 0.5, false, "Colonel Mustard");
                    break;
                case 1:
                    clue = new Clue("A sprinkling of ash", "Ash", RarityType.COMMON, 0, 0.1, true, "Mrs. Peacock");
                    break;
                case 2:
                    clue = new Clue("A recently snuffed candle", "Candle", RarityType.COMMON, 1.00, 0.2, true, "Mr. Green");
                    break;
                case 3:
                    clue = new Clue("A cracked picture frame", "Framed Picture", RarityType.COMMON, 3.00, 1.0, false, "Mrs. White");
                    break;
                case 4:
                    clue = new Clue("A threatening note", "Letter", RarityType.COMMON, 0.2, 0.1, false, "Miss Scarlet");
                    break;
                case 5:
                    clue = new Clue("A small, red handkerchief", "Handkerchief", RarityType.COMMON, 0.5, 0.1, true, "Dr. Orchid");
                    break;
            }

            return clue;
        }

        public Clue MakeRandomClue(bool isAccurate, string incriminate)
        {
            Random rand = new Random();
            int randomValue = rand.Next(0, 5);

            Clue clue = new Clue("", "", RarityType.COMMON, -1, -1, false, "");

            switch (randomValue)
            {
                case 0:
                    clue = new Clue("A conspicuous note", "Note", RarityType.COMMON, 1.50, 0.5, isAccurate, incriminate);
                    break;
                case 1:
                    clue = new Clue("A sprinkling of ash", "Ash", RarityType.COMMON, 0, 0.1, isAccurate, incriminate);
                    break;
                case 2:
                    clue = new Clue("A recently snuffed candle", "Candle", RarityType.COMMON, 1.00, 0.2, isAccurate, incriminate);
                    break;
                case 3:
                    clue = new Clue("A cracked picture frame", "Framed Picture", RarityType.COMMON, 3.00, 1.0, isAccurate, incriminate);
                    break;
                case 4:
                    clue = new Clue("A threatening note", "Letter", RarityType.COMMON, 0.2, 0.1, isAccurate, incriminate);
                    break;
                case 5:
                    clue = new Clue("A small, red handkerchief", "Handkerchief", RarityType.COMMON, 0.5, 0.1, isAccurate, incriminate);
                    break;
            }

            return clue;
        }

        public Item MakeRandomItem()
        {
            Random rand = new Random();
            int newItemChoice = rand.Next(1, 11);
            Item item;
            if(newItemChoice % 2 == 0 && newItemChoice <= 5)
            {
                item = MakeRandomWeapon(RarityType.COMMON);
            }
            else if(newItemChoice % 2 == 0 && newItemChoice > 5)
            {
                item = MakeRandomWeapon(RarityType.RARE);
            }
            else
            {
                item = MakeRandomClue();
            }

            return item;
        }

        public Weapon MakeRandomWeapon(RarityType rarity)
        {
            Random rand = new Random();
            int randomValue = rand.Next(0, 5);

            Weapon weapon = new Weapon("", "", rarity, -1, -1, 0, DamageType.SLASHING, false, "");

            switch (randomValue)
            {
                case 0:
                    weapon = new Weapon("A large candlestick", "Rope", rarity, 5.0, 3.5, 5, DamageType.BLUDGEONING, false, "Dr. Orchid");
                    break;
                case 1:
                    weapon = new Weapon("A small dagger", "Dagger", rarity, 10.5, 5.5, 15, DamageType.SLASHING, true, "Colonel Mustard"); 
                    break;
                case 2:
                    weapon = new Weapon("A heavy wrench", "Wrench", rarity, 6.99, 8.0, 10, DamageType.BLUDGEONING, false, "Mrs. Peacock");
                    break;
                case 3:
                    weapon = new Weapon("An empty revolver", "Revolver", rarity, 25.0, 6.0, 20, DamageType.PIERCING, true, "Prof. Plum");
                    break;
                case 4:
                    weapon = new Weapon("A long metal pipe", "Pipe", rarity, 2.5, 3.5, 7, DamageType.BLUDGEONING, false, "Miss Scarlet");
                    break;
                case 5:
                    weapon = new Weapon("A bloodied CLUE boardgame", "CLUE (Boardgame)", rarity, 19.99, 5.0, 5, DamageType.BLUDGEONING, true, "Mr. Green");
                    break;
            }

            return weapon;
        }

        public Weapon MakeRandomWeapon(RarityType rarity, bool isAccurate, string incriminate)
        {
            Random rand = new Random();
            int randomValue = rand.Next(0, 5);

            Weapon weapon = new Weapon("", "", rarity, -1, -1, 0, DamageType.SLASHING, false, "");

            switch (randomValue)
            {
                case 0:
                    weapon = new Weapon("A large candlestick", "Rope", rarity, 5.0, 3.5, 5, DamageType.BLUDGEONING, isAccurate, incriminate);
                    break;
                case 1:
                    weapon = new Weapon("A small dagger", "Dagger", rarity, 10.5, 5.5, 15, DamageType.SLASHING, isAccurate, incriminate);
                    break;
                case 2:
                    weapon = new Weapon("A heavy wrench", "Wrench", rarity, 6.99, 8.0, 10, DamageType.BLUDGEONING, isAccurate, incriminate);
                    break;
                case 3:
                    weapon = new Weapon("An empty revolver", "Revolver", rarity, 25.0, 6.0, 20, DamageType.PIERCING, isAccurate, incriminate);
                    break;
                case 4:
                    weapon = new Weapon("A long metal pipe", "Pipe", rarity, 2.5, 3.5, 7, DamageType.BLUDGEONING, isAccurate, incriminate);
                    break;
                case 5:
                    weapon = new Weapon("A bloodied CLUE boardgame", "CLUE (Boardgame)", rarity, 19.99, 5.0, 5, DamageType.BLUDGEONING, isAccurate, incriminate);
                    break;
            }

            return weapon;
        }
    }
}
