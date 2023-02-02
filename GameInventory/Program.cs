namespace GameInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("Gaming", "Gamer", RarityType.COMMON, 1.5, 105.3);
            Item item2 = new Item("Rare type item", "Thing", RarityType.RARE, 200, 1054);
            Weapon weapon = new Weapon("Its big", "Big Axe", RarityType.UNCOMMON, 400, 205.5, 50, DamageType.SLASHING, true, "Mrs. White");
            Clue clue = new Clue("its a clue", "Paper", RarityType.COMMON, 10, 1, false, "Colonel Mustard");
            BackPack pack = new BackPack();
            ItemFactory factory = new ItemFactory();
            pack.Add(factory.MakeRandomClue());


            pack.Add(item);
            pack.Add(item2);
            pack.Add(weapon);
            pack.Add(clue);

            //Console.WriteLine(item);
            //Console.WriteLine(item2);
            //Console.WriteLine(weapon);
            //Console.WriteLine(pack.ListWeapons());
            //Console.WriteLine(pack.ListClues());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(pack.ListItems());
        }
    }
}