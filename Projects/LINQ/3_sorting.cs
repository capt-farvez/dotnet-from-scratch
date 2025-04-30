class Person{
    public string Name { get; set; }
    public int Age { get; set; }
}

class LINQ_Sorting{
    public static void OrderBy(){
        int[] Numbers = {2, 5, 6, 8, 9, 5};

        Console.WriteLine("Numbers in Accending Order ");
        var sortedNumbers = Numbers.OrderBy(num => num);
        foreach (var num in sortedNumbers){
            Console.Write($"{num} ");
        }

        Console.WriteLine("\n Numbers in Descending Order ");
        var sortedNumberDescending = Numbers.OrderByDescending(num => num);
        foreach(var num in sortedNumberDescending){
            Console.Write($"{num} ");
        }

        List<Person> persons = new List<Person>(){
            new Person() {Name="Anowar", Age=24},
            new Person() {Name="Hossen", Age=22},
            new Person() {Name="Farvez", Age=23},
        };

        Console.WriteLine($"\n Sorted by name in accending Order ");
        var sortedByName = persons.OrderBy(person => person.Name);
        foreach(var person in sortedByName){
            Console.WriteLine($"{person.Name} - {person.Age} ");
        }

        Console.WriteLine($"\n Sorted by Age in accending Order ");
        var sortedByAge = persons.OrderBy(person => person.Age);
        foreach(var person in sortedByAge){
            Console.WriteLine($"{person.Name} - {person.Age} ");
        }

    }
    public static void ThenBy(){
        List<Person> persons = new List<Person>(){
            new Person() {Name="Anowar", Age=24},
            new Person() {Name="Hossen", Age=22},
            new Person() {Name="Anowar", Age=23},
        };

        Console.WriteLine($"Sorted by Name Only ");
        var sortedByName = persons.OrderBy(person => person.Name);
        foreach(var person in sortedByName){
            Console.WriteLine($"{person.Name} - {person.Age} ");
        }

        Console.WriteLine($"Sorted by Name then Age ");
        var sortedByNameAge = persons.OrderBy(person => person.Name).ThenBy(person=> person.Age);
        foreach(var person in sortedByNameAge){
            Console.WriteLine($"{person.Name} - {person.Age} ");
        }
    }
}