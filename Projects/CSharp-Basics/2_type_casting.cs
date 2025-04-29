using System;

class TypeCasting{
    public static void Type_casting(){
        int num = 10;
        double dNum = num; // Implicit casting
        Console.WriteLine("Implicit Casting: " + dNum);

       double num2 = 20.50;
       int num3 = (int)num2;
       Console.WriteLine("Explicit Casting: " + num3 +  num);
       Console.WriteLine("Summary: " + (num3 + num));

       int num4 = 12345;
       Console.WriteLine(Convert.ToString(num4));

    }
}