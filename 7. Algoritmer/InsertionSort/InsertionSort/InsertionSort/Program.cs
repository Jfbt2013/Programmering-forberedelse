using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        class InsertionSort
        {

            // Function to sort array
            // using insertion sort
            void InsertSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 1; i < n; ++i)
                {
                    int key = arr[i];
                    int j = i - 1;

                    // Move elements of arr[0..i-1],
                    // that are greater than key,
                    // to one position ahead of
                    // their current position
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }
            }

            // A utility function to print
            // array of size n
            static void InsertprintArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");

                Console.Write("\n");
            }

            // Driver Code
            public static void Main()
            {
                int[] arr = { 12, 11, 13, 5, 6 };
                InsertionSort ob = new InsertionSort();
                ob.InsertSort(arr);

                Console.WriteLine("Insertion sorted array: ");
                InsertprintArray(arr);
                Console.ReadKey(); 
            }
        }
    }
}
