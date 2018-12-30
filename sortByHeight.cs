/*
Some people are standing in a row in a park.There are trees between 
them which cannot be moved. Your task is to rearrange the people by 
their heights in a non-descending order without moving the trees. 
People can be very tall!

Example:
For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortByHeight
{
    class Program
    {
        static int[] sortByHeight(int[] a)
        {
            var list = new List<int>(a);
            var sortedList = new List<int>(from l in list where l > -1 orderby l select l);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == -1)
                    sortedList.Insert(i, list[i]);
            }

            return sortedList.ToArray();
        }
        static void Main(string[] args)
        {
            int[] a = new[] { -1, 150, 190, 170, -1, -1, 160, 180 };
            sortByHeight(a);
        }
    }
}
