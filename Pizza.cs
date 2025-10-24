namespace PizzaStore;

public class Pizza
{
    // properties
    public int PizzaID {  get; set; }  
    public string Name { get; set; }   
    public string Size { get; set; }    
    public double Price { get; set; }  

    // constructor
    public Pizza(int id, string name, string size, double price)
    {
        PizzaID = id;
        Name = name;    
        Size = size;
        Price = price;
    }

    // metode
    public override string ToString()
    {
        return $"{Name} ({Size}) - ({Price} kr.";
    }
}

