class Customer{
    public string Name {get; set;}
    public int Age {get; set;}
}
class LINQ_Quantifiers{
    public static void Quantifiers(){
        List<Customer> Customers = new List<Customer>(){
            new Customer() {Name="Raihan", Age= 25},
            new Customer() {Name="Ali", Age= 19},
            new Customer() {Name="Muhtasim", Age= 55},
            new Customer() {Name="Yemon", Age= 29},
            new Customer() {Name="Mominul", Age= 45},
            new Customer() {Name="Ripa", Age= 50},
        };

        bool allAreAdult = Customers.All(customer => customer.Age > 18);
        Console.WriteLine($"Are all customers adult? - {allAreAdult}");

        bool anyTeenageCustomer = Customers.Any(customer => customer.Age <=19);
        Console.WriteLine($"Any Teenage customer? - {allAreAdult}");

        bool isRaihanContains = Customers.Select(customer => customer.Name).Contains("Raihan");
        Console.WriteLine($"Is Raihan Present here? - {isRaihanContains}");
 
    }
}