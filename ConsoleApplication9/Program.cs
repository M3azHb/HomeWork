using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{

    public class BinarySearch
    {
        // تابع البحث الثنائي بأسلوب تكراري
        public static int IterativeBinarySearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("The array is empty or invalid");
                return -1;
            }

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid; // تم العثور على القيمة
                else if (array[mid] < target)
                    left = mid + 1; // البحث في النصف الأيمن
                else
                    right = mid - 1; // البحث في النصف الأيسر
            }

            Console.WriteLine("Value not found");
            return -1; // القيمة غير موجودة
        }

        // تابع البحث الثنائي بأسلوب عودي
        public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("The array is empty or invalid");
                return -1;
            }

            if (left > right)
            {
                Console.WriteLine("Value not found");
                return -1; // القيمة غير موجودة
            }

            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid; // تم العثور على القيمة
            else if (array[mid] < target)
                return RecursiveBinarySearch(array, target, mid + 1, right); // البحث في النصف الأيمن
            else
                return RecursiveBinarySearch(array, target, left, mid - 1); // البحث في النصف الأيسر
        }
    }

    // مثال على الاستخدام:
    class Program
    {
        static void Main()
        {
            int[] sortedArray = { 1, 5, 7, 9, 2 };

            Console.WriteLine(BinarySearch.IterativeBinarySearch(sortedArray, 5)); // يجب أن يطبع: 2

            Console.WriteLine(BinarySearch.RecursiveBinarySearch(sortedArray, 5, 0, sortedArray.Length - 1)); // يجب أن يطبع: 2

            Console.WriteLine(BinarySearch.IterativeBinarySearch(sortedArray, 4)); // يجب أن يطبع: "value not found" ثم -1

            Console.WriteLine(BinarySearch.RecursiveBinarySearch(sortedArray, 4, 0, sortedArray.Length - 1)); // يجب أن يطبع: "value not found" ثم -1
        }
    

}

}
