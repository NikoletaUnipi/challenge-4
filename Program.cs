using System;
using System.Linq;
namespace challenge_4
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine(GetVowelCount("ask"));
        }
        public static int GetVowelCount(string str)
        {
           
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
           
            return str.ToList().Count((x => vowels.Contains(x) == true)); ;
        }
    }
}
