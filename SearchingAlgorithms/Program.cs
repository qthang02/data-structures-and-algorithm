internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
        int key = 5;

        Console.WriteLine(LinearSearch(arr, key));
        Console.WriteLine(BinarySearch(arr, key));
    }


    /* 
       Linear Search Algorithm
       * Time Complexity: O(n)
       * Space Complexity: O(1) 
    */
    private static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                return i;
            }
        }

        return -1;
    }   

    /* 
       Binary Search Algorithm
       * Time Complexity: O(log n)
       * Space Complexity: O(1) 
    */

    private static int BinarySearch(int[] arr, int key)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == key)
            {
                return mid;
            }
            else if (arr[mid] < key)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }   
}