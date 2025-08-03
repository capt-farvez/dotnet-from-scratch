/*
    String/Texts Exercise

    1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, 
    if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

    2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, 
    exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

    3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. 
    If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

    4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. 
    For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

    5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
    So, if the user enters "inadequate", the program should display 6 on the console.

*/

namespace StringText
{
    class StringText
    {
        public static void Ex1()
        {
            Console.Write("Enter numbers separated by hyphen: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty Input");
                return;
            }

            string[] numbers = input.Split('-');
            int[] numArray = Array.ConvertAll(numbers, int.Parse);
            Array.Sort(numArray);

            bool isConsecutive = true;
            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i] != numArray[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        public static void Ex2()
        {
            Console.Write("Enter numbers separated by hyphen (or press Enter to exit): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty Input");
                return;
            }

            string[] numbers = input.Split('-');
            HashSet<string> uniqueNumbers = new HashSet<string>();

            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Add(number.Trim()))
                {
                    Console.WriteLine($"Duplicate found: {number}");
                    return;
                }
            }

            Console.WriteLine("No duplicates found.");
        }

        public static void Ex3()
        {
            Console.Write("Enter time in 24-hour format (HH:MM): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalMinutes >= 0 && time.TotalMinutes < 1440)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void Ex4()
        {
            Console.Write("Enter words separated by space: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty Input");
                return;
            }

            string[] words = input.Split(' ');
            string variableName = string.Join("", words.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
            Console.WriteLine(variableName);
        }
        
        public static void Ex5()
        {
            Console.Write("Enter an English word: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty Input");
                return;
            }

            int vowelCount = input.Count(c => "aeiouAEIOU".Contains(c));
            Console.WriteLine($"Number of vowels: {vowelCount}");
        }
    }
}