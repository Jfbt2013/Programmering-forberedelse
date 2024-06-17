using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorter
{
    public class Sorting2
    {
        public List<int> sortingAscending(List<int> collection) 
        {
            return collection.OrderBy(x => x).ToList();
        }

        public List<int> sortingDescending(List<int> collection)
        {
            return collection.OrderByDescending(x => x).ToList();
        }

        public List<int> bubbleSortPositiveNumbers(List<int> collection)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < collection.Count; i++)
            {
                swapped = false;
                for (j = 0; j < collection.Count - i - 1; j++)
                {
                    if (collection[j] < 0)
                    {
                        throw new FormatException();
                    }  

                    if (collection[j] > collection[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                {
                    break;
                }
            }

            return collection;
        }
    }
}
