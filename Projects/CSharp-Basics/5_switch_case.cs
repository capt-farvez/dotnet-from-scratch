using System;

class SwitchCase{
    public static void SwitchCaseDemo(){
        Console.WriteLine("Enter a number between 1 and 3:");
        int num = Convert.ToInt32(Console.ReadLine());
        switch(num){
            case 1:
                Console.WriteLine("Number is 1");
                break;
            case 2:
                Console.WriteLine("Number is 2");
                break;
            case 3:
                Console.WriteLine("Number is 3");
                break;
            default:
                Console.WriteLine("Number is not between 1 and 3");
                SwitchCaseDemo();
                break;
        }
    }
}