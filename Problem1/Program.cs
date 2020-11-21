using System;

namespace Problem1
{
    class Program
    {

        private static void NeedleHaystack(string haystack, string needle, int threshold)
        {
            

            if (threshold > needle.Length) return;

            //per cdo karakter te stringut needle
            for (int i = 0; i < needle.Length; i++)
            {
                
                for (int j = 0; j < needle.Length - i + 1; j++)
                {
                    if (j >= threshold)
                    {
                         
                        var sequence = needle.Substring(i, j);

                        var haystack_offset = haystack.IndexOf(sequence);

                        var needle_offset = needle.IndexOf(sequence);

                        if (haystack_offset != -1 && needle_offset != -1) 
                            Console.WriteLine($"sequence of length = {j} found at haystack offset {haystack_offset}, needle offset {needle_offset}");

                        Console.ReadKey();
                    }
                }
            }

        }

        

        static void Main(string[] args)
        {


            string haystack = "vnk2435kvabco8awkh125kjneytbcd12qjhb4acd123xmnbqwnw4t";
            string needle = "abcd1234"; 

            int threshold = 3;

           NeedleHaystack(haystack, needle, threshold);

        }
    }
}
