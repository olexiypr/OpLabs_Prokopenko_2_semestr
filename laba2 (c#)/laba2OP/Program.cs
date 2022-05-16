using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace laba2OP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            string nameInputFile="text.txt";
            string nameResultFile = "text1.txt";
            Worker [] arrOfWorkers = new []   //масив працівників
            {
                new Worker("Володимирович", "14.07.1990", "02.05.2013"),
                new Worker("Петрович", "11.05.1987", "14.08.2009"),
                new Worker("Васильович", "15.04.1960", "21.11.1990"),
                new Worker("Романов", "27.02.1983", "11.11.2011"),
                //Worker("Stepanenko", "12.12.1980", "14.04.2000")
            };
            Module_Write.cleanFile(nameInputFile);  //створення або очищення текстових файлів
            Module_Write.cleanFile(nameResultFile);
            for (int i = 0; i < arrOfWorkers.Length; i++)  //пооб'єктний запис в файл
            {
                Module_Write.writeObjectInFile(arrOfWorkers[i], nameInputFile);
            }
            int sizeInputFile = arrOfWorkers.Length;
            int sizeResultFile = 0;
            sizeInputFile=Module_Write.addWorker(nameInputFile,sizeInputFile);  //додавати чи не додавати працівника
            Console.WriteLine("------Всі працівники:-------- ");
            Module_Read.printFile(nameInputFile, sizeInputFile);  //виведення вхідного файлу
            Console.WriteLine("------Всі працівники в яких др в цьому місяці і стаж >5 років-----");
            sizeResultFile=Module_Read.DeSerialize(nameInputFile, sizeInputFile, nameResultFile);  //десеріалізація
            Console.WriteLine("-----Всі працівники які працюють не пізніше ніж з 25 років та мають стаж >10 років-----");
            Module_Read.printFile(nameResultFile, sizeResultFile); //виеденення результуючого файлу
        }
    }
}