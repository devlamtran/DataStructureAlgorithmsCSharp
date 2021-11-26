using DataStructure;
using System;

namespace Test
{
    public class TestCase
    {
        
        public static void Main(string[] args)
        {
            int[] input = {1,5,9,2,4,12,10,15,11,-4,0,6,5,10};
            SortAlgorithmsArray.QuickSort(input);
            Console.WriteLine("After delete element has value 5");

            for (int i = 0; i < input.Length; i++) { 
                Console.WriteLine((input)[i]);

            }

        }
    }
}
