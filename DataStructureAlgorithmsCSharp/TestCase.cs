using DataStructure;
using System;

namespace Test
{
    public class TestCase
    {
        public static void Main(string[] args)
        {
            int[] input = {1,2,3,2,5,6,2,8};
            Console.WriteLine("After delete element has value 5");

            for (int i = 0; i < ArrayStructure.DeleteElementDuplicateInArray(input).Length; i++)
            {
                Console.WriteLine(ArrayStructure.DeleteElementDuplicateInArray(input)[i]);

            }

        }
    }
}
