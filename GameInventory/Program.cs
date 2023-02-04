///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1 - GameInventory
// Description: Main method that fills backpack with random items and displays them
//
///////////////////////////////////////////////////////////////////////////////

namespace GameInventory
{
    internal class Program
    {
        /// <summary>
        /// Main method that fills the backpack with random items and displays
        /// them to the user
        /// </summary>
        /// <param name="args">String array for command line parameters</param>
        static void Main(string[] args)
        {
            ItemFactory factory = new ItemFactory();
            BackPack pack = new BackPack();

            for(int i = 0; i < 10; i++)
            {
                pack.Add(factory.MakeRandomItem());
            }

            Console.WriteLine(pack.ListItems());
        }
    }
}