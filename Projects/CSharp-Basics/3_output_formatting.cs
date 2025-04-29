using System;

class OutputFormatting{
    public static void Opf()
    {
        int num1, num2, result;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine()); 
        result = num1 - num2;
        Console.WriteLine($"Subtraction: {num1} - {num2} = {result}");

        result = num1 + num2;
        Console.WriteLine("Addition: {0} + {1} = {2}", num1, num2, result);

        result = num1 * num2;
        Console.WriteLine("Multiplication: " + num1 + " * " + num2 + " = " + result);

        double div;
        div = (double)num1 / num2;
        Console.WriteLine("Division: {0} / {1} = {2:F2}", num1, num2, div);
        Console.WriteLine($"Division: {num1} / {num2} = {div:F2}");
    }
}