
namespace PizzaStore;

public class Order
{
    // properties
    public int OrderID { get; set; }
    public string Date { get; set; }
    public double TotalPrice { get; set; }
    public string Status { get; set; }
    public Pizza Pizza { get; set; }
    public Customer Customer { get; set; }


    // constructor 
    public Order(int id, string date, double totalPrice, string status, Pizza pizza, Customer customer)
    {
        OrderID = id;
        Date = date;
        TotalPrice = totalPrice;
        Status = status;
        Pizza = pizza;
        Customer = customer;

    }

    // metode for totalpris
    private double CalculateTotalPrice()
    {
        double deliveryFee = 40.0;
        return Pizza.Price + deliveryFee;
    }

    // metode for samler customer og pizza
    public string PrintOrderInfo()
    {

        return $"{Customer.CustomerID} ({Pizza.PizzaID}), Price: {CalculateTotalPrice()}";


    }
}
