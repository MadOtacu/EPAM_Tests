using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Sort(nums);
        }
        static void Sort (int[] arr)
        {
            Console.WriteLine("Введите десять чисел:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}