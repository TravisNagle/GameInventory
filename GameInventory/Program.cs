namespace GameInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("Gaming", "Gamer", RarityType.COMMON, 1.5, 105.3);
            Item item2 = new Item("Rare type item", "Thing", RarityType.RARE, 200, 1054);
            Weapon weapon = new Weapon("Its big", "Big Axe", RarityType.UNCOMMON, 400, 205.5, 50, DamageType.SLASHING);

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.WriteLine(weapon);
        }
    }
}