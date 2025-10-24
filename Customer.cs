
namespace PizzaStore;

public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Adress { get; set; }



    // constructor
    public Customer(int id, string name, string phone, string adress)
    {
        CustomerID = id;
        Name = name;
        Phone = phone;
        Adress = adress;
    }

    // metode
    public override string ToString()
    {
        return $"{Name} ({Phone}), Adresse: {Adress}";
    }
}
