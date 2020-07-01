using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace SearchAlgorithms
{
    public class SortedArray
    {
        public static int FindElement(int[] arr, int elem)
        {
            return BinarySearch(arr, 0, arr.Length - 1, elem);
        }

        private static int BinarySearch(int[] arr, int first, int last, int elem) 
        {
            if(last - first == 1)
            {
                if (arr[first] == elem) return first;
                return -1;
            }
            int middle = (first + last) / 2;
            if (arr[middle] < elem)
            {
                // recurse on right
                return BinarySearch(arr, middle + 1, last, elem);                 
            } else if (elem < arr[middle])
            {
                // recurse on left
                return BinarySearch(arr, first, middle, elem);
            } else
            {
                return middle;
            }


        }

    }
}
