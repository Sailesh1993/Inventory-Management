public class Item {
    private string barcode;
    private string name;
    private int quantity;

    public string Barcode
    {
        get{ return barcode; }
    }
    public string Name
    {
        get{ return name;}
    }
    public int Quantity
    {
       get { return quantity;}
    }
    public Item(string barcode, string name, int quantity)
    {
        this.barcode = barcode;
        this.name = name;
        this.quantity = quantity;

    }
    public void IncreaseQuantity(int amount)
    {
        if(amount >= 0)
        {
            quantity -= amount;
            if(quantity < 0)
            {
                quantity = 0; 
            }
        }
    }
    public void DecreaseQuantity (int amount)
    {
        if(amount >= 0)
        {
            quantity -= amount;
            if(quantity < 0)
            {
                quantity = 0;
            }
        }
    }
}
