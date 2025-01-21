using System;
					
internal class Program
{
     static void Main(string[] args)
     {
         Random n = new Random();
		 CreateArray();
       
 
     }
     static int[] CreateArray()
     {
		 Console.WriteLine("enter the length of your array");
		int arrayLength = Convert.ToInt32(Console.ReadLine());
		int[] numbers = new int[arrayLength];
		
		 for (int i=0; i < arrayLength; i++)
		 {
		 	Console.WriteLine($"enter number {i+1}:");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		 }
		 
		 Console.WriteLine("your array length:");
		 foreach (int number in numbers)
		 {
		 	Console.WriteLine(number);
		 }
		 return numbers;
     }
     static void menu(int array)
     {
 			
		 Console.WriteLine("Enter what search you want to do: Linear Search, Binary Search, Bubble Sort, Merge Sort,");
		 int option = int.Parse(Console.ReadLine());
		 
     }
     static void BubbleSort(int[] a)
     {
     }
     static void Merge(int[] a, int low, int mid, int high)
     {
         int i, j, k;
         int num1 = mid - low + 1;
         int num2 = high - mid;
         int[] L = new int[num1];
         int[] R = new int[num2];
         for (i = 0; i < num1; i++)
         {
             L[i] = a[low + i];
         }
         for (j = 0; j < num2; j++)
         {
             R[j] = a[mid + j + 1];
         }
         i = 0;
         j = 0;
         k = low;
         while (i < num1 && j < num2)
         {
             if (L[i] <= R[j])
             {
                 a[k] = L[i];
                 i++;
             }
             else
             {
                 a[k] = R[j];
                 j++;
             }
             k++;
         }
         while (i < num1)
         {
             a[k] = L[i];
             i++;
             k++;
         }
         while (j < num2)
         {
             a[k] = R[j];
             j++; k++;
         }
     }
     static void MergeSortRecursive(int[] a, int low, int high)
     {
         if (low < high)
         {
             int mid = (low + high) / 2;
             MergeSortRecursive(a, low, mid);
             MergeSortRecursive(a, mid + 1, high);
             Merge(a, low, mid, high);
         }
     }
     static bool LinearSearch(int[] a, int numToFind)
     {
 		return true;
     }
     static bool BinarySearch(int[] a, int numToFind)
     {
		 return true;
     }
}



//working bubble sort code


//using System;

//class BubbleSort
//{
	// static void Main()
    	//{
        	//int[] array = { 64544, 365554, 2345, 453, 546, 1, 999 };
        	//BubbleSort1(array);
       		 //Console.WriteLine("Sorted array:");
        	//PrintArray(array);
    //}

    //static void BubbleSort1(int[] arr)
    //{
        //int n = arr.Length;
        //for (int i = 0; i < n - 1; i++)
        //{
            //for (int j = 0; j < n - i - 1; j++)
            //{
                //if (arr[j] > arr[j + 1])
                //{
                    // Swap arr[j] and arr[j + 1]
                    //int temp = arr[j];
                    //arr[j] = arr[j + 1];
                    //arr[j + 1] = temp;
                //}
            //}
        //}
    //}

    //static void PrintArray(int[] arr)
    //{
        //foreach (int element in arr)
        //{
           // Console.Write(element + " ");
        //}
        //Console.WriteLine();
    //}


//working merge sort code

//using System;

//class MergeSort
//{
    //static void Main()
    //{
       //int[] array = { 38, 27, 43, 3, 9, 82, 10 };
       //Console.WriteLine("Original array:");
       //PrintArray(array);

        //MergeSort(array, 0, array.Length - 1);

        //Console.WriteLine("Sorted array:");
        //PrintArray(array);
    //}

    //static void MergeSort(int[] arr, int left, int right)
    //{
        //if (left < right)
        //{
            //int middle = (left + right) / 2;

            //MergeSort(arr, left, middle);
            //MergeSort(arr, middle + 1, right);

           //Merge(arr, left, middle, right);
        //}
   //}

    //static void Merge(int[] arr, int left, int middle, int right)
    //{
        //int n1 = middle - left + 1;
        //int n2 = right - middle;

        //int[] leftArray = new int[n1];
        //int[] rightArray = new int[n2];

        //Array.Copy(arr, left, leftArray, 0, n1);
        //Array.Copy(arr, middle + 1, rightArray, 0, n2);

        //int i = 0, j = 0;
        //int k = left;

        //while (i < n1 && j < n2)
        //{
            //if (leftArray[i] <= rightArray[j])
            //{
                //arr[k] = leftArray[i];
                //i++;
            //}
            //else
            //{
                //arr[k] = rightArray[j];
                //j++;
            //}
            //k++;
        //}

        //while (i < n1)
        //{
            //arr[k] = leftArray[i];
            //i++;
            //k++;
        //}

        //while (j < n2)
        //{
            //arr[k] = rightArray[j];
            //j++;
            //k++;
        //}
    //}

    //static void PrintArray(int[] arr)
    //{
        //foreach (int element in arr)
        //{
            //Console.Write(element + " ");
        //}
        //Console.WriteLine();
    //}
//}

//working linear search code

//using System;

//class LinearSearch
//{
    //static void Main()
    //{
        //int[] array = { 10, 23, 45, 70, 11, 15 };
        //int target = 70;
        //int result = LinearSearch(array, target);

        //if (result == -1)
        //{
            //Console.WriteLine("Element not found in the array.");
        //}
        //else
        //{
            //Console.WriteLine("Element found at index: " + result);
        //}
    //}

    //static int LinearSearch(int[] arr, int target)
    //{
        //for (int i = 0; i < arr.Length; i++)
        //{
            //if (arr[i] == target)
            //{
                //return i;
            //}
        //}
        //return -1;
    //}
//}



// working binary search code

//using System;

//class BinarySearch
//{
    //static void Main()
    //{
        //int[] array = { 2, 3, 4, 10, 40 };
        //int target = 10;
        //int result = BinarySearch(array, target);

        //if (result == -1)
        //{
            //Console.WriteLine("Element not found in the array.");
        //}
        //else
        //{
            //Console.WriteLine("Element found at index: " + result);
        //}
    //}

    //static int BinarySearch(int[] arr, int target)
    //{
        //int left = 0;
        //int right = arr.Length - 1;

        //while (left <= right)
        //{
            //int middle = left + (right - left) / 2;

            //if (arr[middle] == target)
            //{
                //return middle;
            //}

            //if (arr[middle] < target)
            //{
                //left = middle + 1;
            //}
            //else
            //{
                //right = middle - 1;
            //}
        //}

        //return -1;
    //}
//}
