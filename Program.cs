namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> shoppingList = new LinkedList<string>();
            shoppingList.AddFirst("Хляб");
            shoppingList.AddLast("Мляко");
            shoppingList.AddFirst("Яйца");
            shoppingList.AddLast("Плодове");

            Console.WriteLine("Списък за пазаруване:");
            PrintList(shoppingList);

            shoppingList.RemoveFirst();
            Console.WriteLine();
            Console.WriteLine("След купуване на първия елемент:");
            
            PrintList(shoppingList);

            shoppingList.RemoveLast();
            Console.WriteLine();
            Console.WriteLine("След купуване на последния елемент:");
            
            PrintList(shoppingList);
        }

        static void PrintList(LinkedList<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}