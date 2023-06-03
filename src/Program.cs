
class Program 
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory(100);
        inventory.AddItem("300", "Item1", 20);
        inventory.AddItem("301", "Item2", 30);
        inventory.AddItem("302", "Item3", 40);
        inventory.ViewInventory();
        Console.WriteLine();
        inventory.IncreaseQuantity(9, "300");
        inventory.DecreaseQuantity(13, "302");
        inventory.ViewInventory();
        Console.WriteLine();
        inventory.RemoveItem("302");
        inventory.ViewInventory();
        Console.WriteLine();
        Printer printer = new Printer();
        printer.PrintItem(inventory.items["300"]);
        printer.PrintInventory(inventory);
        inventory = null;
        Console.ReadLine();

    }
}

