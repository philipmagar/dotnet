using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 14, 19,2,3 ,7,15 };
            SortAlgo sortAlgo = new SortAlgo();

            Console.WriteLine("Before Sorting:");
            sortAlgo.displayArray(array);

            sortAlgo.bubbleSort(array);

            Console.WriteLine("After Sorting:");
            sortAlgo.displayArray(array);
        }
    }
}
