/*
    File Exercise:

    1- Write a program that reads a text file and displays the number of words.

    2- Write a program that reads a text file and displays the longest word in the file. 
*/

namespace FilesIO
{
    class FilesIO
    {
        public static void Ex1(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found");
                return;
            }

            string content = File.ReadAllText(filePath);
            int wordCount = content.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Number of words: {wordCount}");
        }

        public static void Ex2(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found");
                return;
            }

            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
            Console.WriteLine($"Longest word: {longestWord}");
        }
    }
}