using System;

class ConditinalStatement{
    public static void Conditions(){
        Console.Write("Enter a number: ");  // Read input from user
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 5){
            Console.WriteLine("Number is greater than 5");
        }
        else if(num == 5){
            Console.WriteLine("Number is equal to 5");
        }
        else {
            Console.WriteLine("Number is less than 5");
        }

        if(num%2 == 0){
            Console.WriteLine("Number is even");
        }
        else{
            Console.WriteLine("Number is odd");
        }
        
    }
}