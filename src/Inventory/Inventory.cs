

public class Inventory
{
    public Dictionary<string, Item> items;
    public int maxCapacity;

    public Inventory(int maxCapacity)
    {
        items = new Dictionary<string, Item>();
        this.maxCapacity = maxCapacity;
    }

    public bool AddItem(string barcode, string name, int quantity)
    {
        if (items.Count >= maxCapacity)
        {
            return false;
        }

        if (items.ContainsKey(barcode))
        {
            items[barcode].IncreaseQuantity(quantity);
        }
        else
        {
            Item newItem = new Item(barcode, name, quantity);
            items.Add(barcode, newItem);
        }

        return true;
    }

    public bool RemoveItem(string barcode)
    {
        if (items.ContainsKey(barcode))
        {
            items.Remove(barcode);
            return true;
        }

        return false;
    }

    public void IncreaseQuantity(int amount, string barcode)
    {
        if (items.ContainsKey(barcode))
        {
            items[barcode].IncreaseQuantity(amount);
        }
    }

    public void DecreaseQuantity(int amount, string barcode)
    {
        if (items.ContainsKey(barcode))
        {
            items[barcode].DecreaseQuantity(amount);
        }
    }

    public void ViewInventory()
    {
        foreach (Item item in items.Values)
        {
            Console.WriteLine($"Barcode: {item.Barcode}, Name: {item.Name}, Quantity: {item.Quantity}");
        }
    }

    ~Inventory()
    {
        Console.WriteLine("Inventory is destroyed.");
    }
}