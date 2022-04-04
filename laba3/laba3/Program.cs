using System;
using System.Collections.Generic;

namespace laba3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Random random = new Random();
            Book[] library = new Book[]
            {
               new Book ("Max O.P.","1vs1onSF", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Pushkin O.S.", "zxcWithDantes", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Snoop D.", "Travka", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Random N.F.", "RandomName", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("RandomPIB1", "RandomName1", random.Next(170, 350), random.Next(1940, 2022))
            };
            List<Book> filteredLib = filter(library);
            if (filteredLib.Count == 0)
            {
                Console.WriteLine("В даному діапазоні років немає жодної книги!");
            }
            else
            {
                findMaxCountPages(filteredLib).Print();
            }
        }

        public static List<Book> filter(Book [] lib)
        {
            Console.WriteLine("Всі книги: ");
            for (int i = 0; i < lib.Length; i++)
            {
                lib[i].Print();
            }
            Console.WriteLine("Введіть нижню межу років: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть верхню межу років: ");
            int end = Convert.ToInt32(Console.ReadLine());
            List<Book> filteredLib = new List<Book>();
            Console.WriteLine("Книги у яких різ випуску знаходиться у вказаному діапазоні: ");
            foreach (var i in lib)
            {
                if (i.GetYearOfPb() >= start&& i.GetYearOfPb()<end)
                {
                    i.Print();
                    filteredLib.Add(i);
                }
            }
            return filteredLib;
        }

        public static Book findMaxCountPages(List<Book> lib)
        {
            Book temp = lib[0];
            foreach (var i in lib)
            {
                if (i.GetCountOfPage()>temp.GetCountOfPage())
                {
                    temp = i;
                }
            }
            return temp;
        } 
    }
}