using System;

namespace _07.GenericArraySort
{
    class GenericArraySort
    {
        static void Main()
        {
            int[] number = { 1, 3, 4, 5, 1, 0, 5 };
            string[] strings = { "zaz", "sba", "baa", "azis" };
            DateTime[] dates =
            {
                new DateTime(2002, 3, 1), new DateTime(2003, 5, 6), new DateTime(2001, 1, 1)
            };
            BubleSort(number);
            BubleSort(strings);
            BubleSort(dates);
        }

        static void BubleSort<T>(T[] arr) where T : IComparable<T>
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swap = true;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T old = a;
            a = b;
            b = old;
        }
    }
}