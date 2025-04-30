class ForeignFruits{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class LINQ_Select{
    public static void Select()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squares = numbers.Select(x => x * x);
        Console.WriteLine("Squares of numbers: ");
        foreach (var square in squares){
            Console.Write($"{square} ");
        }
        Console.WriteLine("\n---------------------------------------------------- ");
        List<ForeignFruits> foreignFruits = new List<ForeignFruits>(){
            new ForeignFruits(){ Name = "Apple", Quantity = 10, Price = 1.5 },
            new ForeignFruits(){ Name = "Banana", Quantity = 20, Price = 0.5 },
            new ForeignFruits(){ Name = "Cherry", Quantity = 30, Price = 2.0 },
            new ForeignFruits(){ Name = "Date", Quantity = 40, Price = 3.0 },
        };
        var ForeignFruitsWithPrice = foreignFruits.Select(fruit => (fruit.Name, fruit.Price));
        Console.WriteLine("ForeignFruits with their prices: ");
        foreach (var fruit in ForeignFruitsWithPrice){
            Console.WriteLine($"{fruit.Name} - ${fruit.Price}");
        }

        Console.WriteLine("\n---------------------------------------------------- ");
        Console.WriteLine($" SelectMany  ");
        List<List<int>> listOfLists = new List<List<int>>(){
            new List<int>(){ 1, 2, 8 },
            new List<int>(){ 3, 1, 6 },
            new List<int>(){ 7, 8, 4 },
            new List<int>(){ 5, 9, 3 },
        };
        var flattenedList = listOfLists.SelectMany(list => list);
        Console.WriteLine("Flattened List: ");

        foreach(var num in flattenedList){
            Console.Write($"{num} ");
        }
    }

}