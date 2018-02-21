using System;
using System.Linq;

namespace Anagram
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("banana","anaban")); //true
            Console.WriteLine(IsAnagram("bonbon","nobnob")); //true
            Console.WriteLine(IsAnagram("xyz","abc")); //false
            Console.WriteLine(IsAnagram("bananaaa","bananaa")); //false
        }

        public static Boolean IsAnagram(string word1, string word2)
        {
            char[] word1Chars = word1.ToCharArray();
            char[] word2Chars = word2.ToCharArray();

            for (var i = 0; i < word1Chars.Length; i++)
            {
                char c1 = word1Chars[i];
                for (var j = 0; j < word2Chars.Length; j++)
                {
                    char c2 = word2Chars[j];
                    if (c1 == c2)
                    {
                        word1Chars[i] = '0';
                        word2Chars[j] = '0';
                        break;
                    }
                }
                if (word1Chars.SequenceEqual(word2Chars))
                    return true;
            }
            return false;
        }
    }
}
