using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_med_Algoritmer_og_Test
{
    internal class Program
    {
        //MergeSort kode er taget fra GeeksforGeeks
        //Link til siden: https://www.geeksforgeeks.org/merge-sort/ 

        class MergeSort
        {
            void merge(int[] arr, int l, int m, int r)
            {
                // Find sizes of two
                // subarrays to be merged
                int n1 = m - l + 1;
                int n2 = r - m;

                // Create temp arrays
                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarray array
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }


            }
            void sort(int[] arr, int l, int r)
            {
                if (l < r)
                {

                    // Find the middle point
                    int m = l + (r - l) / 2;

                    // Sort first and second halves
                    sort(arr, l, m);
                    sort(arr, m + 1, r);

                    // Merge the sorted halves
                    merge(arr, l, m, r);
                }
            }
            static void MergeprintArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }


            public static void Main(string[] args)
            {
                //Opsætter array
                int[] arr = { 2, 1, 6, 4, 100, 50, 66, 33, 69, 20, 420, 10 };

                //Printer arrayet
                Console.WriteLine("Given array is");
                MergeprintArray(arr);

                //Sortere arrayet
                MergeSort ob = new MergeSort();
                ob.sort(arr, 0, arr.Length - 1);

                //Printer det nu sorterede array
                Console.WriteLine("Merge Sort svar: ");

                Console.WriteLine("\nSorted array is");
                MergeprintArray(arr);

                Console.ReadKey();
            }
        }
    }
}





        


        

   


    





