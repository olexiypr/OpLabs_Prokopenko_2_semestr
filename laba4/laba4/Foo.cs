using System;
using System.Diagnostics.CodeAnalysis;

namespace laba4
{
    public class Foo
    {
        public static void EnterSize(ref int sizeY, ref int sizeX)
        {
            Console.WriteLine("Введіть розмір в форматі X Y, або однне число для квадратної матриці");
            string size = Console.ReadLine();
            if (size.IndexOf(' ')!=-1)
            {
                sizeX = Convert.ToInt32(size.Substring(0, size.IndexOf(' ')));
                sizeY = Convert.ToInt32(size.Substring(size.IndexOf(' ')));
                return;
            }
            sizeY = Convert.ToInt32(size);
            sizeX = Convert.ToInt32(size);
        }
    }
}