using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingProject
{
    /// <remarks>
    /// Demonstrates a variety of sorting algorithms
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Demonstrates a variety of sorting algorithms
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            PrintSortedArray("Original Array", GetUnsortedArray());

            // bubble sort
            int[] array = GetUnsortedArray();
            BubbleSort(ref array);
            PrintSortedArray("Bulbasaur", array);

            // selection sort
            array = GetUnsortedArray();
            SelectionSort(ref array);
            PrintSortedArray("Selection Sort", array);

            // insertion sort
            array = GetUnsortedArray();
            InsertionSort(ref array);
            PrintSortedArray("Insertion Sort", array);

            // merge sort
            array = GetUnsortedArray();
            array = MergeSort(array);
            PrintSortedArray("Merge Sort", array);

            // Array sort
            array = GetUnsortedArray();
            Array.Sort(array);
            PrintSortedArray("Array Sort", array);

            Console.WriteLine();
        }

        #region Sorting methods

        /// <summary>
        /// Sorts the given array using bubble sort
        /// </summary>
        /// <param name="array">the array to sort</param>
        private static void BubbleSort(ref int[] array)
        {
            // work from right to left
            for (int k = array.Length - 1; k > 0; k--)
            {
                // traverse unsorted portion of array
                for (int i = 0; i < k; i++)
                {
                    // check for a swap
                    if (array[i] > array[i + 1])
                    {
                        SwapElements(i, i + 1, ref array);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts the given array using selection sort
        /// </summary>
        /// <param name="array">the array to sort</param>
        private static void SelectionSort(ref int[] array)
        {
            int numElements = array.Length;

            // work from left to right
            for (int k = 0; k < numElements; k++)
            {
                int minLocation = k;

                // traverse unsorted portion of array
                for (int i = k + 1; i < numElements; i++)
                {
                    // check for a new minimum location
                    if (array[i] < array[minLocation])
                    {
                        minLocation = i;
                    }
                }

                // swap the elements
                SwapElements(k, minLocation, ref array);

                PrintSortedArray("Step " + (k + 1), array);
            }
        }

        /// <summary>
        /// Sorts the given array using insertion sort
        /// </summary>
        /// <param name="array">the array to sort</param>
        private static void InsertionSort(ref int[] array)
        {
            // process array from left to right
            for (int k = 1; k < array.Length; k++)
            {
                // set new value to be inserted
                int value = array[k];

                // find insertion point for new value, shifting as we go
                int i = k - 1;
                while (i >= 0 && 
                    value < array[i])
                {
                    array[i + 1] = array[i];
                    i--;
                }

                // insert new value
                array[i + 1] = value;
            }
        }

        /// <summary>
        /// Sorts the given array using merge sort
        /// </summary>
        /// <param name="array">the array to sort</param>
        private static int[] MergeSort(int[] array)
        {
            // termination condition when array is a single element
            if (array.Length == 1)
            {
                return array;
            }

            // build left and right halves for recursion
            int middleLocation = array.Length / 2;
            int[] left = CopyRange(0, middleLocation - 1, array);
            int[] right = CopyRange(middleLocation, array.Length - 1, array);

            // recursively sort both halves
            left = MergeSort(left);
            right = MergeSort(right);

            // merge the two halves together and return
            return Merge(left, right);
        }

        /// <summary>
        /// Merges two arrays into a single sorted array
        /// </summary>
        /// <param name="left">the left array</param>
        /// <param name="right">the right array</param>
        /// <returns>the merged array</returns>
        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int resultIndex = 0;

            // loop continues while both left and right have at least one element
            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < left.Length &&
                rightIndex < right.Length)
            {
                // add appropriate element to result
                if (left[leftIndex] <= right[rightIndex])
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                }
                resultIndex++;
            }

            // copy rest of left or right array as appropriate
            while (leftIndex < left.Length)
            {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
                resultIndex++;
            }
            while (rightIndex < right.Length)
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
                resultIndex++;
            }

            // return merged array
            return result;
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Returns an unsorted array
        /// </summary>
        /// <returns>the unsorted array</returns>
        private static int[] GetUnsortedArray()
        {
            //int[] array = { 6, 7, 5, 3, 2, 4 };
            int[] array = { 8, 3, 6, 1, 9, 2, 5, 7 };
            return array;
        }

        /// <summary>
        /// Swaps the given elements in the array
        /// </summary>
        /// <param name="firstLocation">the first location to swap</param>
        /// <param name="secondLocation">the second location to swap</param>
        /// <param name="array">the array</param>
        private static void SwapElements(int firstLocation, int secondLocation, ref int[] array)
        {
            int temp = array[firstLocation];
            array[firstLocation] = array[secondLocation];
            array[secondLocation] = temp;
        }

        /// <summary>
        /// Copies the elements of the given array from start to end index into a new array
        /// </summary>
        /// <param name="startIndex">the start index for the copy</param>
        /// <param name="endIndex">the end index for the copy</param>
        /// <param name="array">the array to copy from</param>
        /// <returns>the new array</returns>
        private static int[] CopyRange(int startIndex, int endIndex, int[] array)
        {
            int[] newArray = new int[endIndex - startIndex + 1];
            int newIndex = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
            return newArray;
        }

        /// <summary>
        /// Prints the array with the given heading
        /// </summary>
        /// <param name="heading">the heading</param>
        /// <param name="array">the array</param>
        private static void PrintSortedArray(string heading, int[] array)
        {
            Console.WriteLine();
            Console.WriteLine(heading);
            int numElements = array.Length;
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(array[i]);
                if (i < numElements - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        #endregion
    }
}
