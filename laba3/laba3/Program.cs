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
               new Book ("Пушкін","Збірка віршів", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Шевченко", "Кобзар", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Котляревський", " Полтавка", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Котляревський", "Енеїда", random.Next(170, 350), random.Next(1940, 2022)),
               new Book ("Коллінз", "Голодні ігри", random.Next(170, 350), random.Next(1940, 2022))
            };
            List<Book> filteredLib = Functions.filter(library);
            if (filteredLib.Count == 0)
            {
                Console.WriteLine("-----В даному діапазоні років немає жодної книги!-----");
            }
            else
            {
                Console.WriteLine("-----Книга з найбільшою кількістю стрінок:-----");
                Functions.findMaxCountPages(filteredLib).Print();
            }
        }
    }
}