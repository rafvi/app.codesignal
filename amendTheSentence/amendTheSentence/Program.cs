/*
Do ciąg s:
 - Umieść pojedynczą spację między słowami zaczynającymi się wielką literą.
 - Konwertuj wielkie litery na małe litery.

Przykład:
Dla s = "CodesignalIsAwesome", oczekiwany wynik:
amendTheSentence(s) = "codesignal is awesome";

Dla s = "Hello", oczekiwany wynik:
amendTheSentence(s) = "hello".
 */

using System;

namespace amendTheSentence
{
    class Program
    {
        static string amendTheSentence(string s)
        {
            string res = Convert.ToString(s[0]);
            char[] arr = s.ToCharArray();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                    res = res + " " + arr[i];
                else
                    res = res + arr[i];
            }

            return res.ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(amendTheSentence("codesignal is awesome"));
            Console.WriteLine(amendTheSentence("Hello"));
            Console.ReadKey();
        }
    }
}
