using System;
using System.Collections.Generic;

namespace laba3
{
    public static class Functions
    {
        public static List<Book> filter(Book [] lib)
        {
            Console.WriteLine("-----Всі книги:-----");
            for (int i = 0; i < lib.Length; i++)
            {
                lib[i].Print();
            }
            Console.WriteLine("-----Введіть нижню межу років: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----Введіть верхню межу років: ");
            int end = Convert.ToInt32(Console.ReadLine());
            List<Book> filteredLib = new List<Book>();
            Console.WriteLine("----Книги у яких різ випуску знаходиться у вказаному діапазоні:----");
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