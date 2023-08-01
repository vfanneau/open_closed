namespace open_closed
{
    public class Program
    {
        public static void Main()
        {
            Factory factory = new Factory();

            IEnumerable<ICraftable> craftables = new List<ICraftable>
            {
                new Wood(),
                new Metal()
            };

            Production production = factory.Craft(craftables);

            Console.WriteLine(production);
        }
    }
}