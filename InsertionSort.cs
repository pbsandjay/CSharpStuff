using System;

namespace InsertionSort
{
    class Program
    {
        /// <summary>
        /// Driver code 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 6, 8, 2 };
            InsertionSort(array); //passes array to InsertionSort 
            PrintArray(array); //passes array to be printed after sorting them in InsertionSort
        }


        /// <summary>
        /// Insertion Sort sorting algorithm
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) //do me second
            {
                for (int k = i + 1; k > 0; k--) //do me first 
                {
                    if (arr[k] < arr[k-1])
                    {
                        int temp = arr[k - 1];
                        arr[k - 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }

            return arr;
        }
        /// <summary>
        /// Prints the array after being sorted
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
            foreach (var numbers in arr)
            {
                Console.WriteLine(numbers);
                Console.ReadLine();
            }
        }
    }
}
