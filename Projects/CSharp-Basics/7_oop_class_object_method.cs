using System;

class Person
{
    public string name;
    public int age;

    public void setValue(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, This is {name} and {age} years old.");
    }
}

class OopClassObject{
    public static void OopCO()
    {
        Person person1 = new Person();
        person1.name = "Anowar Hossen";
        person1.age = 24;
        person1.Introduce();

        Person person2 = new Person();
        person2.setValue("John Chena", 50);
        person2.Introduce();
    }
}