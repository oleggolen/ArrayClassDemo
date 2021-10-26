using System;

namespace ArrayClassDemo
{
    internal static class Program
    {
        private static void PrintArray<T>(Array<T> array)
        {
            for(var i=0;i<array.Length;i++)
                Console.Write($"{array[i] } ");
            Console.WriteLine();
        }
        private static void Main()
        {
            var random = new Random();
            Console.Write("Enter length of array: ");
            var length = int.Parse(Console.ReadLine() ?? "0");
            var arr = new int[length];
            for (var i = 0; i < length; i++)
                arr[i] = random.Next(1, 20);
            var array = new IntArray(arr);
            var defaultArray = new Array<int>();
            Console.Write("Your array: ");
            PrintArray(array);
            Console.Write("Default array: ");
            PrintArray(defaultArray);
            Console.WriteLine($"Sum elements: {array.Sum()}");
            Console.Write("Enter element to change: ");
            var value = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter index to change: ");
            var index = int.Parse(Console.ReadLine() ?? "0");
            array[index] = value;
            Console.Write("Your changed array: ");
            PrintArray(array);
            Console.Write("Enter element to insert: ");
            value = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter index to insert element: ");
            index = int.Parse(Console.ReadLine() ?? "0");
            array.Insert(index,value);
            Console.Write("Inserted array: ");
            PrintArray(array);
            defaultArray.Insert(0,1);
            Console.Write("Inserted default array: ");
            PrintArray(defaultArray);
        }
    }
}