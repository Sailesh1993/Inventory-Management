public class Printer
{
    public void PrintItem(Item item)
    {
        Console.WriteLine($"Name: {item.Name}, Barcode: {item.Barcode}");
    }
    public void PrintInventory(Inventory inventory)
    {
        int uniqueItemCount = inventory.items.Count;
        int totalQuantity = 0;

    foreach(Item item in inventory.items.Values)
    {
        totalQuantity += item.Quantity;
    }
    Console.WriteLine($"Unique Items: {uniqueItemCount}, Total Items: {totalQuantity}");
    }
}