using System;

namespace StringAdvancedHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word: ");
            MiddleCharacter();
            Console.WriteLine();
            string s2 = "Fancy fifth fly aloof";
            char b1 = 'F';
            FunctiontoCount(s2, b1);

            Facebook();

            Console.WriteLine("Ho() return: ");
            Console.WriteLine(Ho());
            Console.WriteLine("Ho(Ho()) return: ");
            Console.WriteLine(Ho(Ho()));
            Console.WriteLine("Ho(Ho(Ho())) return: ");
            Console.WriteLine(Ho(Ho(Ho())));
        }
        //1.You are going to be given a word. Your job is to return the middle character of the 
        //word. If the word's length is odd, return the middle character. If the word's length is 
        //even, return the middle 2 characters.
        //"test" should return "es"
        //"testing" should return "t"
        //"middle" should return "dd"
        //"A" should return "A" #Input
        //A word (string) of length 0 < str < 1000. #Output
        static void MiddleCharacter()
        {
            string s = Console.ReadLine();
            if (s.Length % 2 != 0)
            {
                Console.WriteLine($"If the word's length is odd, the middle character is {s[s.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"If the word's length is even, the 2 middle characters are {s[s.Length / 2 - 1]}{s[s.Length / 2]}");
            }
        }
        //The goal of this kata is to write a function that takes two inputs: a string and a character. 
        //The function will count the number of times that character appears in the string. The count is case insensitive.
        //For example:
        //countChar("fizzbuzz","z") => 4 
        //countChar("Fancy fifth fly aloof","f") => 5 The character can be any alphanumeric character.
        static void FunctiontoCount(string a, char b)
        {
            int contor = 0;
            foreach (char c in a)
                if (StringComparer.CurrentCultureIgnoreCase.Equals(char.ToString(c), char.ToString(b)))
                {
                    contor = contor + 1;
                }
            Console.WriteLine($"The character appears in the given string for {contor} times");
            Console.WriteLine();
        }
        //likes [] // must be "no one likes this" 
        //likes ["Peter"] // must be "Peter likes this" 
        //likes ["Jacob", "Alex"] // must be "Jacob and Alex like this" 
        //likes ["Max", "John", "Mark"] // must be "Max, John and Mark like this" 
        //likes ["Alex", "Jacob", "Mark", "Max"] // must be "Alex, Jacob and 2 others like this"
        static void Facebook()
        {
            string[] myArray = new string[] { "Peter", "Jacob", "Alex", "Max", "John", "Mark" };
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == " ")
                {
                    Console.WriteLine($"No one likes this ");
                }
                if (myArray[0].IndexOf(myArray[0]) == i)
                {
                    Console.WriteLine(myArray[0] + " likes this");
                }
                if (myArray[1].IndexOf(myArray[1]) == i || myArray[2].IndexOf(myArray[2]) == i)
                {
                    Console.WriteLine($"{myArray[1]} and {myArray[2]} likes this");
                }
                if (myArray[3].IndexOf(myArray[3]) == i || myArray[4].IndexOf(myArray[4]) == i || myArray[5].IndexOf(myArray[5]) == i)
                {
                    Console.WriteLine($"{myArray[3]},{myArray[4]} and {myArray[5]} likes this");
                }
                if (myArray[2].IndexOf(myArray[2]) == i + 1 || myArray[1].IndexOf(myArray[1]) == i)
                {
                    int b = myArray.Length - 2;
                    Console.WriteLine($"{myArray[2]},{myArray[1]} and {b} others likes this");
                }
            }
            Console.WriteLine();
        }
        //Santa is learning programming. And what could be the first program, he wants to write? 
        //Yes, the "Hello world!" of Christmas: "Ho Ho Ho!". He wants to write a function ho(), 
        //which should have the following return values:
        //ho(); // should return "Ho!" 
        //ho(ho()); // should return "Ho Ho!" 
        //ho(ho(ho())); // should return "Ho Ho Ho!"
        static string Ho(string s = "")
        {
            if (string.IsNullOrWhiteSpace(s))
                return "Ho!";
            else
                return "Ho " + s;
        }
    }
}
