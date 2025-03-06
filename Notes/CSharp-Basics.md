## **1️⃣ Introduction to C#**
- C# is a **modern, object-oriented programming (OOP) language** developed by Microsoft.  
- It is mainly used for **web development (ASP.NET), desktop apps, game development (Unity), and cloud-based applications**.  
- C# runs on the **.NET runtime**, which provides various libraries and tools.  

### **🔹 Basic Syntax**  
```csharp
using System; // Importing the System namespace

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!"); // Print output to console
    }
}
```

---

## **2️⃣ Data Types & Variables**
| **Type**     | **Description**  | **Example** |
|-------------|----------------|------------|
| `int`       | Integer numbers | `int age = 25;` |
| `double`    | Decimal numbers | `double pi = 3.14;` |
| `char`      | Single character | `char grade = 'A';` |
| `string`    | Text data | `string name = "Alice";` |
| `bool`      | True/False | `bool isAlive = true;` |

### **🔹 Declaring Variables**
```csharp
int number = 10;
double price = 99.99;
char letter = 'A';
string message = "Hello!";
bool isActive = true;
```

---

## **3️⃣ Control Flow (Conditions & Loops)**
### **🔹 If-Else Statement**
```csharp
int age = 18;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
```

### **🔹 Switch Case**
```csharp
char grade = 'B';
switch (grade)
{
    case 'A': Console.WriteLine("Excellent!"); break;
    case 'B': Console.WriteLine("Good job!"); break;
    default: Console.WriteLine("Try harder!"); break;
}
```

### **🔹 Loops**
```csharp
// For loop
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}

// While loop
int count = 1;
while (count <= 3)
{
    Console.WriteLine("Count: " + count);
    count++;
}
```

---

## **4️⃣ Methods (Functions)**
### **🔹 Defining and Calling Methods**
```csharp
static void Greet()
{
    Console.WriteLine("Hello, welcome to C#!");
}

static void Main()
{
    Greet(); // Calling the function
}
```

### **🔹 Methods with Parameters**
```csharp
static int Add(int a, int b)
{
    return a + b;
}

static void Main()
{
    int sum = Add(5, 7);
    Console.WriteLine("Sum: " + sum);
}
```

---

## **5️⃣ Arrays & Lists**
### **🔹 Arrays (Fixed Size)**
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers[0]); // Output: 1
```

### **🔹 Lists (Dynamic Size)**
```csharp
List<string> names = new List<string>() { "Alice", "Bob" };
names.Add("Charlie");
Console.WriteLine(names[2]); // Output: Charlie
```

---

## **6️⃣ Object-Oriented Programming (OOP)**
### **🔹 Classes and Objects**
```csharp
class Car
{
    public string brand;
    public void Honk()
    {
        Console.WriteLine(brand + " says Beep!");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.brand = "Toyota";
        myCar.Honk(); // Output: Toyota says Beep!
    }
}
```

### **🔹 Constructor (Initializing Objects)**
```csharp
class Car
{
    public string brand;

    // Constructor
    public Car(string carBrand)
    {
        brand = carBrand;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Tesla");
        Console.WriteLine(myCar.brand); // Output: Tesla
    }
}
```

---

## **7️⃣ Exception Handling (Try-Catch)**
```csharp
try
{
    int num = 10 / 0; // This will cause an exception
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Execution completed.");
}
```

---

## **8️⃣ LINQ (Querying Data Easily)**
```csharp
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
foreach (var num in evenNumbers)
{
    Console.WriteLine(num); // Output: 2, 4, 6
}
```

---

## **9️⃣ File Handling (Reading & Writing)**
### **🔹 Writing to a File**
```csharp
File.WriteAllText("test.txt", "Hello, C#!");
```

### **🔹 Reading from a File**
```csharp
string text = File.ReadAllText("test.txt");
Console.WriteLine(text);
```
