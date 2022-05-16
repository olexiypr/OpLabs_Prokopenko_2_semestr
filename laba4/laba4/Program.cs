using System;
using System.IO;

namespace laba4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Random random = new Random();
            int sizeY=0, sizeX=0;
            BoolMatrix m1;
            BoolMatrix m2;
            Foo.EnterSize(ref sizeY, ref sizeX);
            if (sizeY==sizeX)
            {
                m1 = new BoolMatrix(sizeY, random);
                m2 = new BoolMatrix(sizeY, random);
            }
            else
            {
                m1 = new BoolMatrix(sizeY, sizeX, random);
                m2 = new BoolMatrix(sizeY, sizeX, random);
            }
            BoolMatrix m3 = m1 | m2;
            Console.WriteLine("Матриця 1: ");
            m1.PrintMatrix();
            Console.WriteLine("Матриця 2:");
            m2.PrintMatrix();
            Console.WriteLine("Матриця 3:");
            m3.PrintMatrix();
            Console.WriteLine("Інверсія матриці 3: ");
            m3 = ~ m3;
            m3.PrintMatrix();
            Console.WriteLine("Кількість правдивих значень: ");
            Console.WriteLine(m3.CountTrueValue());
        }
    }
}