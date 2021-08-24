using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        public static bool IsAnagram(string first, string second)
        {
            var f1 = first.Length;
            var s1 = second.Length;
            if(f1!=s1)
            {
                Console.WriteLine("Cannot be anagram");
                return false;
            }
            
            char[] first_char = first.ToLower().ToCharArray();
            char[] second_char = second.ToLower().ToCharArray();
            Array.Sort(first_char);            
            Array.Sort(second_char);

            for (int i = 0; i < first_char.Length; i++)
            {
                if (first[i].ToString() != second[i].ToString())
                {
                    Console.WriteLine("Cannot be anagram");
                    return false;
                }                
            }

            Console.WriteLine("Can be anagram");
            return true;
        }

        static void Main(string[] args)
        {
            string first_string;
            string second_string;
            Console.WriteLine("Enter the words. I will check if it is anagrams.");
            Console.WriteLine("First word: ");
            first_string = Console.ReadLine();
            Console.WriteLine("Second word: ");
            second_string = Console.ReadLine();
            IsAnagram(first_string, second_string);
        }
    }
}
