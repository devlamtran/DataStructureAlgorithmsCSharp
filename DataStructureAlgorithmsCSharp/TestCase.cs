using DataStructure;
using System;

namespace Test
{
    public class TestCase
    {
        public static void Main(string[] args)
        {
            int[] input = {1,2,7,2,5,6,3,2,9};
            Console.WriteLine("After delete element has value 5");

            for (int i = 0; i < ArrayStructure.EditGivenElementWithValueInArray(2,8,input).Length; i++)
            {
                Console.WriteLine(ArrayStructure.EditGivenElementWithValueInArray(2, 8, input)[i]);

            }

        }
    }
}
