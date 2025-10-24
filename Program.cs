

// UML 1 opgave


// 1. pizza
using PizzaStore;

Pizza pizza = new Pizza(1, "Margherita", "Medium", 80);
Console.WriteLine(pizza);

// 2. pizza
Pizza pizza2 = new Pizza(2, "Salatpizza", "Stor", 120);
Console.WriteLine(pizza2);

// 3. pizza 
Pizza pizza3 = new Pizza(3, "pep med dres", "familie", 150);
Console.WriteLine(pizza3);



// 1. customer
Customer customer = new Customer(1, "Anna", "12345678", "Gade 1");
Console.WriteLine(customer);


// 2. customer
Customer customer2 = new Customer(2, "Berit", "23456789", "Gade 2");
Console.WriteLine(customer2);

// 3. customer 
Customer customer3 = new Customer(2, "Jens", "34567890", "Gade 3");
Console.Write(customer3);


// 1. order
Order order = new Order(1, "22/10", 33.33, "færdig", pizza, customer);
Console.WriteLine(order.PrintOrderInfo());

// 2. order
Order order2 = new Order(2, "23/10", 44.44, "klar", pizza2, customer);
Console.WriteLine(order2.PrintOrderInfo());

// 3. order 
Order order3 = new Order(3, "24/10", 55.55, "ready eddy", pizza3, customer);
Console.WriteLine(order3.PrintOrderInfo());

