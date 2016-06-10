using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] incominArray = new int[11] {3, 2, 5, 6, 7, 1, 4, 0, 8, 1, 9 };

            int[] arrayForBubbleSorting = new int[11] { 3, 2, 5, 6, 7, 1, 4, 0, 8, 1, 9 };



            int iterationsCounter = 0;

            Console.WriteLine("Bubble sorting");
            PrintArrayToConsole(arrayForBubbleSorting);

            int swapCount;

            //bubble sorting
            //Repeat iteration while swapCount>0 that means sorting is not completed yet, since we did some swap(s) in last iteration
            do
            {
                swapCount = 0;

                Console.WriteLine("Iteration #{0}", iterationsCounter + 1);

                //Take 2 elements and swap if first is bigger than second
                for (int i = 0; i < arrayForBubbleSorting.Length - 1; i++)
                {
                    if (arrayForBubbleSorting[i] > arrayForBubbleSorting[i + 1])
                    {
                        arrayForBubbleSorting = SwapArrayElementsImproved(arrayForBubbleSorting, i, i + 1);
                        //SwapArrayElements(arrayForBubbleSorting, i, i+1);

                        swapCount++;
                    }
                }

                PrintArrayToConsole(arrayForBubbleSorting);
                iterationsCounter++;

            } while (swapCount > 0);

            int[] arrayForInsertionSorting = new int[11] { 2, 3, 4, 5, 6, 1, 4, 3, 2, 1, 1 };    //{ 1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 } 2, 3, 4, 5, 6, 1, 4, 3, 2, 1, 1

            Console.WriteLine("Insertion sorting");
            PrintArrayToConsole(arrayForInsertionSorting);



            //Insertion sorting

            for (int i = 1; i < arrayForInsertionSorting.Length; i++)
            {
                Console.WriteLine("Iteration #{0}", i);

                int j = i;

                while ((j > 0) && (arrayForInsertionSorting[j] < arrayForInsertionSorting[j - 1]))
                {
                    //SwapTwoElementsOfArray(arrayForInsertionSorting[j], arrayForInsertionSorting[j - 1], out arrayForInsertionSorting[j], out arrayForInsertionSorting[j - 1]);

                    Console.WriteLine("arrayForInsertionSorting[{0}] = {1}", j, arrayForInsertionSorting[j]);
                    Console.WriteLine("arrayForInsertionSorting[{0}] = {1}", j - 1, arrayForInsertionSorting[j - 1]);
                    Console.WriteLine();

                    int temp = arrayForInsertionSorting[j];
                    arrayForInsertionSorting[j] = arrayForInsertionSorting[j - 1];
                    arrayForInsertionSorting[j - 1] = temp;

                    Console.WriteLine("arrayForInsertionSorting[{0}] = {1}", j, arrayForInsertionSorting[j]);
                    Console.WriteLine("arrayForInsertionSorting[{0}] = {1}", j - 1, arrayForInsertionSorting[j - 1]);
                    Console.WriteLine();

                    Console.WriteLine(j);
                    j--;
                    Console.WriteLine(j);

                }

            }

            PrintArrayToConsole(arrayForInsertionSorting);


            //for (int i = 1; i < arrayForInsertionSorting.Length; i++)
            //{
            //    Console.WriteLine("Iteration #{0}", i);

            //    int j = i - 1;

            //    //Check if swap is required at all
            //    if (arrayForInsertionSorting[i] < arrayForInsertionSorting[j])
            //    {                   
            //        //Check the position (lent) that the element "i" should be shifted to
            //        while ((j > 0) & (arrayForInsertionSorting[i] < arrayForInsertionSorting[j]))
            //        {                        
            //            if (j > 0)
            //            {
            //                j--;
            //            }

            //            Console.WriteLine("j = {0}", j);
            //        }
            //        arrayForInsertionSorting = SwapArrayElementsImproved( arrayForInsertionSorting, j, i);
            //    }


            //    /*
            //    while ((j > 0) & (arrayForInsertionSorting[i] < arrayForInsertionSorting[j]))
            //    {                    
            //        j--;
            //    }
            //    arrayForInsertionSorting = SwapArrayElementsImproved(arrayForInsertionSorting, j, i);
            //    */

            //    /*
            //    j = i;
            //    while ((j > 0) & (arrayForInsertionSorting[j] < arrayForInsertionSorting[j-1]))
            //    {
            //        //SwapArrayElements(arrayForInsertionSorting, j, j - 1);
            //        SwapTwoElementsOfArray(arrayForInsertionSorting[j], arrayForInsertionSorting[j - 1], out arrayForInsertionSorting[j], out arrayForInsertionSorting[j - 1]);
            //        j--;
            //        PrintArrayToConsole(arrayForInsertionSorting);
            //    }
            //    */

            //    PrintArrayToConsole(arrayForInsertionSorting);

            //}                        

            Console.ReadKey();
            Console.ReadKey();
        }

        //Method to do the swap of elements - not used
        static void SwapTwoElementsOfArray(int firstElement, int secondElement, out int firstElementAfterSwap, out int secondElementAfterSwap)
        {
            firstElement = firstElement + secondElement;
            secondElement = firstElement - secondElement;
            firstElement = firstElement - secondElement;

            firstElementAfterSwap = firstElement;
            secondElementAfterSwap = secondElement;
        }

        //Method to do the simple swap (for bubble only)
        static int[] SwapArrayElements(int[] arrayToSwap, int firstElementIndex, int secondElementIndex)
        {
            arrayToSwap[firstElementIndex] = arrayToSwap[firstElementIndex] + arrayToSwap[secondElementIndex];
            arrayToSwap[secondElementIndex] = arrayToSwap[firstElementIndex] - arrayToSwap[secondElementIndex];
            arrayToSwap[firstElementIndex] = arrayToSwap[firstElementIndex] - arrayToSwap[secondElementIndex];

            return arrayToSwap;
        }



        //Method to do the complicated swap (for insertion and bubble)
        static int[] SwapArrayElementsImproved(int[] arrayToSwap, int firstElementIndex, int secondElementIndex)
        {
            int valueToBeMovedLeft = arrayToSwap[secondElementIndex];

            for (int i = secondElementIndex; i > firstElementIndex; i--)
            {
                arrayToSwap[i] = arrayToSwap[i - 1];
            }

            arrayToSwap[firstElementIndex] = valueToBeMovedLeft;

            return arrayToSwap;
        }


        //Method to print the array
        static void PrintArrayToConsole(int[] arrayForPrinting)
        {
            foreach (int arrayElement in arrayForPrinting)
            {
                Console.Write(" {0} ", arrayElement);
            }
            Console.WriteLine();
        }




    }
}
