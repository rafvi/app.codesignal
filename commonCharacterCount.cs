/*
Given two strings, find the number of common characters between them.

Example:

For s1 = "aabcc" and s2 = "adcaa", the output should be
commonCharacterCount(s1, s2) = 3.

Strings have 3 common characters - 2 "a"s and 1 "c".
*/

using System;

namespace commonCharacterCount
{
    class Program
    {
        static int commonCharacterCount(string s1, string s2)
        {
            int res = 0;
            char[] arr1, arr2;

            arr1 = s1.ToCharArray(0, s1.Length);
            arr2 = s2.ToCharArray(0, s2.Length);

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        res++;
                        arr2[j] = ' ';
                        break;
                    }
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(commonCharacterCount("zzzz", "zzzzzzzz"));
            Console.ReadKey();
        }
    }
}
