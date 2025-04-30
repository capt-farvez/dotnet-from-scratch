class LINQ_Aggregation{
    public static void Aggreration(){
        int[] Numbers = {10, 25, 6, 4, 85, 9, 65};
        
        int Sum = Numbers.Sum();
        Console.WriteLine($"Sum is: {Sum}");
        
        int Count = Numbers.Count();
        Console.WriteLine($"Count is: {Count}");
        
        int Max = Numbers.Max();
        Console.WriteLine($"Max Number is {Max}");
        
        int Min = Numbers.Min();
        Console.WriteLine($"Min Number is {Min}");

        double Avg = Numbers.Average();
        Console.WriteLine($"Average number is {Avg}");

    }
}