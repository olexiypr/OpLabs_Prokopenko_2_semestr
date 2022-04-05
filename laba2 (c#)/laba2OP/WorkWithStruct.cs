using System;

namespace laba2OP
{
    public class WorkWithStruct
    {
        public static int GetStaj(string dateStartWork)  //отримання стажу роботи
        {
            DateTime now=DateTime.Now;
            int dd, mm, yy;
            dd = Convert.ToInt32(dateStartWork.Substring(0, dateStartWork.IndexOf('.')));
            mm = Convert.ToInt32(dateStartWork.Substring(dateStartWork.IndexOf('.') + 1, 2));
            yy = Convert.ToInt32(dateStartWork.Substring(dateStartWork.LastIndexOf('.') + 1, 4));
            if (mm > now.Month)
                return now.Year - yy - 1;
            else if (mm == now.Month)
            {
                if (dd > now.Day)
                    return now.Year - yy - 1;
            }
            return now.Year - yy;
        }

        public static void Print(string name, string birthday, string dateStartWork)  //виведення об'єкту на екран
        {
            Console.Write(name + "  " + birthday + "  " + dateStartWork+"\n");
        }

        public static int GetAge(string birthday)  //отримання віку працівника
        {
            int dd, mm, yy;
            DateTime now=DateTime.Now;
            dd = Convert.ToInt32(birthday.Substring(0, birthday.IndexOf('.')));
            mm = Convert.ToInt32(birthday.Substring(birthday.IndexOf('.') + 1, 2));
            yy = Convert.ToInt32(birthday.Substring(birthday.LastIndexOf('.') + 1, 4));
            if (mm<now.Month) {
                return now.Year-yy-1;
            } else if (mm==now.Month && dd<now.Day) {
                return now.Year-yy-1;
            }
            return now.Year-yy;
        }

        public static int GetMonth(string birthday)  //отримання місяця народження працівника
        {
            int mm;
            mm = Convert.ToInt32(birthday.Substring(birthday.IndexOf('.') + 1, 2));
            return mm;
        }
    }
}