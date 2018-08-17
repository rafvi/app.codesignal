/*
Reverse the order of the bits in a given integer.

Example

For a = 97, the output should be
mirrorBits(a) = 67.

97 equals to 1100001 in binary, which is 1000011 after mirroring, and that is 67 in base 10.

For a = 8, the output should be
mirrorBits(a) = 1.
*/

using System;

namespace mirrorBits
{
    class Program
    {
        static int mirrorBits(int a)
        {
            string str = Convert.ToString(a, 2);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = new string(arr);
            return Convert.ToInt32(str, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(mirrorBits(97));
            Console.ReadKey();
        }
    }
}
