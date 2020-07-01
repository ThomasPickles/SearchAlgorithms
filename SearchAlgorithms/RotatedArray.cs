using System;

namespace SearchAlgorithms
{
    public class RotatedArray
    {
        public static int FindElement(int[] arr, int elem)
        {
            return RotatedBinarySearch(arr, 0, arr.Length - 1, elem);
        }

        private static int RotatedBinarySearch(int[] arr, int first, int last, int elem)
        {
            if (last - first == 1)
            {
                if (arr[first] == elem) return first;
                return -1;
            }
            int middle = (first + last) / 2;
            if (arr[middle] < elem)
            {
                if (arr[first] <= arr[middle]) {
                    // rotation on right, all elements to left < elem
                    RotatedBinarySearch(arr, middle + 1, last, elem);
                } else {
                    // rotation on left - 
                    if (elem < arr[last]) {
                        // Recurse on right
                        RotatedBinarySearch(arr, middle + 1, last, elem);
                    } else
                    {
                        // Recurse on left
                        RotatedBinarySearch(arr, first, middle, elem);
                    }
                
                }
 
            }
            else if (elem < arr[middle])
            {
                if (arr[first] <= arr[middle])
                {
                    // all elements to right > elem
                    RotatedBinarySearch(arr, first, middle, elem);
                }
                else
                {

                    // TODO...
                    return -1;
                }
            }
            else
            {
                return middle;
            }


        }
    }
}