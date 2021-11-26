using System;

namespace DataStructure
{
    public class ArrayStructure
    {
        //find element has value Maximum in array
        //input : given an array
        //output : return an element which has value Maximum in given array
        public static int FindMaximumElementInArray(int[] input)
        {
            int output = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (output < input[i])
                {
                    output = input[i];
                }
            }
            return output;
        }

        //find element has value Minimum in array
        //input : given an array
        //output : return an element which has value Minimum in given array
        public static int FindMinimumElementInArray(int[] input)
        {
            int output = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (output > input[i])
                {
                    output = input[i];
                }
            }
            return output;
        }

        //caculate sum value of element in array
        //input : given an array
        //output : return sum value of element in given array
        public static int SumOfElementInArray(int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += sum + input[i];
            }
            return sum;
        }

        //delete element has value equal given value in array
        //input : given an array, given element
        //output : return an array after delete given element in given array
        public static int[] DeleteElementInArray(int element, int[] input)
        {
            int countElementSameGivenElement = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == element)
                {
                    countElementSameGivenElement++;
                }
            }
            if (countElementSameGivenElement == 0)
            {
                return input;
            }
            int[] indexElementSameGivenElements = new int[countElementSameGivenElement];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == element)
                {
                    for (int j = 0; j < indexElementSameGivenElements.Length; j++)
                    {
                        indexElementSameGivenElements[j] = i;
                    }
                }

            }

            int[] output = null;
            for (int i = 0; i < indexElementSameGivenElements.Length; i++)
            {
                output = DeleteElementInArray(element, DeleteElementWithIndexInArray(input, indexElementSameGivenElements[i]));
            }

            return output;
        }

        //delete element with index in given array
        //input : given an array, given index
        //output : return an array after delete element with index in given array
        public static int[] DeleteElementWithIndexInArray(int[] input, int index)
        {
            if (index < 0 || index > input.Length)
            {
                return input;
            };
            int[] output = new int[input.Length - 1];
            for (int i = 0; i < output.Length; i++)
            {
                if (i < index)
                {
                    output[i] = input[i];
                }
                else
                {
                    output[i] = input[i + 1];
                }

            }
            return output;
        }

        //edit elements in array with given value
        //input : given an array, given value
        //output : return an array after edit elements with given value
        public static int[] EditGivenElementWithValueInArray(int pos, int value, int[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                if (i == pos)
                {
                    input[i] = value;
                }
            }
            return input;
        }

        //delete element duplicate in given array
        //input : given an array stores duplicate element
        //output : return an array after delete element duplicate in given array
        public static int[] DeleteElementDuplicateInArray(int[] input)
        {
            int[] output = null;
            int countElementDuplicate = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        countElementDuplicate++;
                    }
                }
                
            }
            if (countElementDuplicate == 0)
            {
                return input;
            }
            int[] indexElementDuplicates = new int[countElementDuplicate];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        for (int k = 0; k < indexElementDuplicates.Length; k++)
                        {
                            indexElementDuplicates[k] = i;
                        }
                    }
                }                       
            }
            
            for (int i = 0; i < indexElementDuplicates.Length; i++)
            {
                output = DeleteElementDuplicateInArray(DeleteElementWithIndexInArray(input, indexElementDuplicates[i]));
            }

            return output;

        }

    }
}
        
    

