using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // selection sort
            Console.WriteLine("\nSelection Sort\n");
            int[] intArr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            SelectionSort(intArr);
            PrintArray(intArr);

            // bubble sort
            Console.WriteLine("\nBubble Sort\n");
            intArr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            BubbleSort(intArr);
            PrintArray(intArr);

            // quick sort
            Console.WriteLine("\nQuick Sort\n");
            intArr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            quickSort(intArr, 0, intArr.Length - 1);
            PrintArray(intArr);

            // merge sort
            Console.WriteLine("\nMerge Sort\n");
            intArr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] mergedArray = mergeSort(intArr);
            PrintArray(mergedArray);

            Console.ReadKey();

        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void quickSort(int[] A, int start, int end)
        {
            if (end <= start) return;
            int pIndex = partition(A, start, end);

            quickSort(A, start, pIndex - 1);
            quickSort(A, pIndex + 1, end);
        }
        static int partition(int[] A, int start, int end)
        {
            int pivot = A[end];
            int pIndex = start;
            for(int i = start; i < end; i++)
            {
                if(A[i] < pivot)
                {
                    swap(A, i, pIndex);
                    pIndex++;
                }
            }
            swap(A, end, pIndex);
            return pIndex;
        }
        static void swap(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        static int[] mergeSort(int[] arr)
        {

            if (arr.Length <= 1)
                return arr;

            int[] result = new int[arr.Length];
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right;
            if(arr.Length % 2 == 0)
            {
                right = new int[mid];
            }
            else
            {
                right = new int[mid + 1];
            }
            
            for(int i = 0; i < mid; i++)
                left[i] = arr[i];

            int x = 0;
            for (int i = mid; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }
            left = mergeSort(left);
            right = mergeSort(right);
            result = merge(left, right);

            return result;
        }
        static int[] merge(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];
            int a = 0;
            int b = 0;
            int i = 0;

            while (a < arr1.Length || b < arr2.Length)
            {
                if (a < arr1.Length && b < arr2.Length)
                {
                    if (arr1[a] < arr2[b])
                    {
                        res[i] = arr1[a];
                        a++;
                        i++;
                    }
                    else
                    {
                        res[i] = arr2[b];
                        b++;
                        i++;
                    }
                }
                else if (a < arr1.Length)
                {
                    res[i] = arr1[a];
                    a++;
                    i++;
                }
                else if (b < arr2.Length)
                {
                    res[i] = arr2[b];
                    b++;
                    i++;
                }
            }
            return res;
        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool sorted;
            for (int i = 0; i < n; i++)
            {
                sorted = true;
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        sorted = false;
                    }
                if (sorted) return;
            }
        }
    }
}
