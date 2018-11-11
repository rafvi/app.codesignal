
/*
Given an array of strings, return another array containing all of its longest strings.

Example:

For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
allLongestStrings(inputArray) = ["aba", "vcd", "aba"].
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLongestStrings
{
    class Program
    {
        static string[] allLongestStrings(string[] inputArray)
        {
            int maxStr = 0;
            Queue queue = new Queue();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > maxStr)
                {
                    queue.Clear();
                    queue.Enqueue(inputArray[i]);
                    maxStr = inputArray[i].Length;
                }
                else if(inputArray[i].Length == maxStr)
                {
                    queue.Enqueue(inputArray[i]);
                }
            }
            string[] outputArray = new string[queue.Count];
            for (int i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = (string)queue.Dequeue();
            }

            return outputArray;
        }

        static void Main(string[] args)
        {
            string[] _arrStr = new string[5] { "aba", "aa", "ad", "vcd", "aba" };
            allLongestStrings(_arrStr);
        }
    }
}
