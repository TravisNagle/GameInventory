namespace GameInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("Gaming", "Gamer", RarityType.COMMON, 1.5, 105.3);
            Item item2 = new Item("Rare type item", "Thing", RarityType.RARE, 200, 1054);

            Console.WriteLine(item);
            Console.WriteLine(item2);
        }
    }
}