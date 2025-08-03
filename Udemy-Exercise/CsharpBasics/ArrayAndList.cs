/*
    Arrays and Lists Exercises:

    1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        - If no one likes your post, it doesn't display anything.
        - If only one person likes your post, it displays: [Friend's Name] likes your post.
        - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
    Depending on the number of names provided, display a message based on the above pattern.


    2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
    Display the reversed name on the console.

    3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and 
    ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

    4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include 
    duplicates. Display the unique numbers that the user has entered.

    5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or 
    includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in 
    the list. 
*/

namespace ArrayAndList
{
    class ArrayAndList
    {
        public static void Ex1()
        {
            Console.WriteLine("Enter names (press Enter to finish):");
            var names = new List<string>();
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                names.Add(input);
            }

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"{names[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                    break;
                default:
                    Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
                    break;
            }
        }

        public static void Ex2()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reversedName = new string(nameArray);
            Console.WriteLine($"Reversed name: {reversedName}");
        }

        public static void Ex3()
        {
            var numbers = new HashSet<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (!numbers.Add(number))
                    {
                        Console.WriteLine("Error: Number already entered. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            var sortedNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine("Sorted unique numbers: " + string.Join(", ", sortedNumbers));
        }

        public static void Ex4()
        {
            var uniqueNumbers = new HashSet<int>();
            while (true)
            {
                Console.Write("Enter a number (or type 'Quit' to exit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else if (int.TryParse(input, out int number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));
        }

        public static void Ex5()
        {
            while (true)
            {
                Console.Write("Enter a list of comma separated numbers (or type 'Quit' to exit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }

                var numbers = input.Split(',')
                                   .Select(n => n.Trim())
                                   .Where(n => !string.IsNullOrEmpty(n))
                                   .Select(int.Parse)
                                   .ToList();

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue;
                }

                var smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
                Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
            }
        }
        
    }
}