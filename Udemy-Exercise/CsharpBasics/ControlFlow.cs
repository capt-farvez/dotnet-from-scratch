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

    5- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

    6- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers 
    and display it on the console.

    7- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
    For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

    8 - Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
    If the user guesses the number, display “You won"; otherwise, display “You lost". 
    (To make sure the program is behaving correctly, you can display the secret number on the console first.)

    9 - Write a program and ask the user to enter a series of numbers separated by comma. 
    Find the maximum of the numbers and display it on the console. For example, 
    if the user enters “5, 3, 8, 1, 4", the program should display 8.
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
        public static void Ex5()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of numbers between 1 and 100 that are divisible by 3: {count}");
        }

        public static void Ex6()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or type 'ok' to exit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    int number;
                    if (int.TryParse(input, out number))
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
            Console.WriteLine($"Sum of all entered numbers: {sum}");
        }

        public static void Ex7()
        {
            Console.Write("Enter a number to compute its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{number}! = {factorial}");
        }

        public static void Ex8()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            Console.WriteLine($"Secret Number (for testing): {secretNumber}");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess the number (between 1 and 10): ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost.");
        }

        public static void Ex9()
        {
            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int maxNumber = int.MinValue;

            foreach (string number in numbers)
            {
                if (int.TryParse(number.Trim(), out int num))
                {
                    if (num > maxNumber)
                    {
                        maxNumber = num;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid number: {number}");
                }
            }
            Console.WriteLine($"Maximum number is: {maxNumber}");
        }
    }
}