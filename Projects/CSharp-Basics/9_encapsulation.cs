using System;

class PersonE
{
    public string? name;
    private int age;

    // Access using public method to set and get age
    public void setAge(int age){
        this.age = age;
    }
    public int getAge(){
        return this.age;
    }

    //
    public int Age{
        get { return age; }
        set { age = value; }
    }
    public void Introduce()
    {
        Console.WriteLine($"Hi, This is {name} and {age} years old.");
    }
}

class OopEncapsulation{
    public static void OopE()
    {
        PersonE person1 = new PersonE();
        person1.name = "Anowar Hossen";
        // person1.age = 24; // This will give an error because age is private
        person1.setAge(24);
        // Console.WriteLine(person1.age); // This will give an error because age is private
        Console.WriteLine(person1.getAge());
        person1.Introduce();

        PersonE person2 = new PersonE();
        person2.name = "John Cena";
        person2.Age = 50;
        Console.WriteLine(person2.Age);
        person2.Introduce();
        
    }
}