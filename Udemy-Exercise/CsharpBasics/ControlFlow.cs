/*
    Control Flow Exercises:

    1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
    If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
    (This logic is used a lot in applications where values entered into input boxes need to be validated.)

    2- Write a program which takes two numbers from the console and displays the maximum of the two.

    3- Write a program and ask the user to enter the width and height of an image. 
    Then tell if the image is landscape or portrait.

    4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, 
    sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
    Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
    program should display Ok on the console. If the value is above the speed limit, the program should calculate 
    the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
    displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
*/

namespace ControlFlow
{
    class ControlFlow
    {
        public static void Ex1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            if (InputNumber >= 1 && InputNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Ex2()
        {
            Console.WriteLine("Enter 2 numbers for finding Minimum Number");
            int InputNumber1 = Convert.ToInt32(Console.ReadLine());
            int InputNumber2 = Convert.ToInt32(Console.ReadLine());

            if (InputNumber1 > InputNumber2)
            {
                Console.WriteLine("Minimum Number is: " + InputNumber2);
            }
            else if (InputNumber1 < InputNumber2)
            {
                Console.WriteLine("Minimum Number is: " + InputNumber1);
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }

        public static void Ex3()
        {
            Console.Write("Enter the width of the image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of the image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            else if (height > width)
            {
                Console.WriteLine("The image is portrait.");
            }
            else
            {
                Console.WriteLine("The image is square.");
            }
        }

        public static void Ex4()
        {
            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of the car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine($"Demerit Points: {demeritPoints}");
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}