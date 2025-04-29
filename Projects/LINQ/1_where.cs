class Fruits
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class LINQ 
{
    public static void Where()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Using LINQ to filter even numbers
        var evenNumbers = numbers.Where(num => num % 2 == 0);
        Console.WriteLine("Even Numbers: ");
        PrintNumbers(evenNumbers);

        // Using LINQ to filter odd numbers
        var oddNumbers = numbers.Where(num => num % 2 != 0);
        Console.WriteLine("Odd Numbers: ");
        PrintNumbers(oddNumbers);

        List<string> names = new List<string>() { "Apple", "Orange", "Cherry", "Banana", "kiwi" };
        // Using LINQ to filter names that start with 'A'
        var namesStartingWithA = names.Where(name => name.StartsWith("A"));
        Console.WriteLine("Names starting with 'A': ");
        PrintStrings(namesStartingWithA);

        // Using LINQ to filter names that contain length greater than 5
        var longNames = names.Where(name => name.Length > 5);
        Console.WriteLine("Names with length greater than 5: ");
        PrintStrings(longNames);

        Console.WriteLine("---------------------------------------------------- ");

        List<Fruits> fruits = new List<Fruits>(){
            new Fruits(){ Name = "Apple", Quantity = 10 },
            new Fruits(){ Name = "Banana", Quantity = 20 },
            new Fruits(){ Name = "Cherry", Quantity = 30 },
            new Fruits(){ Name = "Date", Quantity = 40 },
            new Fruits(){ Name = "Elderberry", Quantity = 50 },
            new Fruits(){ Name = "Fig", Quantity = 60 },
            new Fruits(){ Name = "Grape", Quantity = 70 },
            new Fruits(){ Name = "Honeydew", Quantity = 80 },
            new Fruits(){ Name = "Kiwi", Quantity = 90 },
            new Fruits(){ Name = "Lemon", Quantity = 100 },
        };

        // Using LINQ to filter fruits with quantity greater than 50
        var fruitsHaveMoreThan50= fruits.Where(fruits=> fruits.Quantity > 50);
        Console.WriteLine("Fruits with quantity greater than 50: ");
        foreach(var fruit in fruitsHaveMoreThan50)
        {
            Console.WriteLine($"{fruit.Name} - {fruit.Quantity}");
        }

    }

    public static void PrintNumbers(IEnumerable<int> Numbers)
    {
        foreach(var num in Numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }

    public static void PrintStrings(IEnumerable<string> strings)
    {
        foreach(var str in strings)
        {
            Console.Write($"{str} ");
        }
        Console.WriteLine();
    }
}