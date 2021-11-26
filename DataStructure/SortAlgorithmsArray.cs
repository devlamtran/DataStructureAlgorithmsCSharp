using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SortAlgorithmsArray
    {
        //Complex: o(n^2)
        public static int[] SelectionSort(int[] input)
        {
            int[] output;
            for (int i = 0; i < input.Length - 1; i++)
            {
                int minValue = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < minValue)
                    {
                        Swap(input, i, j);
                        minValue = input[j];
                    }
                }

            }
            output = input;
            return output;

        }

        public static void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        //Complex: o(n^2)
        public static int[] InsertionSort(int[] input)
        {
            int[] output;
            for (int i = 1; i < input.Length; i++)
            {
                //int minValue = input[i];
                while (i > 0 && input[i] < input[i - 1])
                {
                    Swap(input, i, i - 1);
                    i--;
                }

            }
            output = input;
            return output;

        }

        //Complex: o(n^2)
        public static int[] BubbleSort(int[] input)
        {
            int[] output;
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j + 1);
                    }
                }
            }
            output = input;
            return output;

        }

        public static void QuickSort(int[] input)
        {
            SubSort(input, 0, input.Length - 1);

        }

        public static void SubSort(int[] input, int lower, int upper)
        {
            if (lower < upper)
            {
                int p = Partition(input, lower, upper);
                SubSort(input, lower, p);
                SubSort(input, p + 1, upper);
            }
        }



        public static int Partition(int[] input, int lower, int upper)
        {
            int pivot = input[lower];
            do
            {
                while (input[lower] > pivot)
                {
                    lower++;
                }
                while (input[upper] < pivot)
                {
                    upper--;
                }
                if (lower >= upper)
                {
                    break;
                }
                Swap(input, lower, upper);

            } while (lower <= upper);
            return upper;

        }
    }
}
