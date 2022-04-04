using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using foo;
using foo2;
namespace laba2OP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            string nameInputFile="text.txt";
            string nameResultFile = "text1.txt";
            Worker[] arrOfWorkers = new Worker []
            {
                new Worker("Володимирович", "14.07.1990", "02.05.2013"),
                new Worker("Петрович", "11.05.1987", "14.08.2009"),
                new Worker("Васильович", "15.04.1960", "21.11.1990"),
                new Worker("Романов", "27.02.1983", "11.11.2011"),
                //new Worker("Stepanenko", "12.12.1980", "14.04.2000")
            };
            Module_Write.cleanFile(nameInputFile);
            Module_Write.cleanFile(nameResultFile);
            for (int i = 0; i < arrOfWorkers.Length; i++)
            {
                Module_Write.writeObjectInFile(arrOfWorkers[i], nameInputFile);
            }

            int sizeInputFile = arrOfWorkers.Length;
            int sizeResultFile = 0;
            sizeInputFile=Module_Write.addWorker(nameInputFile,sizeInputFile);
            Console.WriteLine("Всі працівники: ");
            Module_Read.printFile(nameInputFile, sizeInputFile);
            Console.WriteLine("Всі працівники в яких др в цьому місяці і стаж >5 років");
            sizeResultFile=Module_Read.DeSer(nameInputFile, sizeInputFile, nameResultFile);
            Console.WriteLine("Всі працівники які працюють не пізніше ніж з 25 років та мають стаж >10 років");
            Module_Read.printFile(nameResultFile, sizeResultFile);
        }
    }
}