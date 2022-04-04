using System;

namespace laba3
{
    public class Book
    {
        private string pib, title;
        private int publicationYear, countOfPages;

        public Book(string pib, string title, int countOfPages, int publicationYear)
        {
            this.pib = pib;
            this.title = title;
            this.publicationYear = publicationYear;
            this.countOfPages = countOfPages;
        }
        public int GetCountOfPage () 
        {
            return countOfPages;
        }
        public int GetYearOfPb () 
        {
            return publicationYear;
        }

        public void Print()
        {
            Console.WriteLine($"{pib} {title} {countOfPages} {publicationYear}");
        }
    }
}