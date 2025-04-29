using System;

class PersonP
{
    public string name;
    public int age;

    public PersonP(string n, int a)
    {
        this.name = n;
        this.age = a;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hi, This is {name} and {age} years old.");
    }
}

class OopConstructor{
    public static void OopC()
    {
        PersonP person1 = new PersonP("Anowar Hossen", 24);
        person1.Introduce();
        PersonP person2 = new PersonP("John Cena", 50);
        person2.Introduce();
    }
}