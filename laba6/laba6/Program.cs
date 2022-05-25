using System;
using System.Threading;

namespace laba6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread.Sleep(200);
            double [] arr = RandomFillArr(10);
            Tree tree = new Tree();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + "  ");
                tree.Add(arr[i]);
            }
            Console.WriteLine();
            Node max = new Node(0);
            Node min = new Node(0);
            tree.FindMax(ref max);
            tree.FindMin(ref min);
            Console.WriteLine($"Max: {max.data} min: {min.data}");
            tree.PrintTree(tree.root, 1);
            (max.data, min.data) = (min.data, max.data);
            Console.WriteLine("After swap: ");
            tree.PrintTree(tree.root, 1);
        }
        private static double [] RandomFillArr(int count)
        {
            Random rnd = new Random();
            double[] arr = new double [count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = (double)rnd.Next(10000) / 100;
            }
            return arr;
        }
    }
}