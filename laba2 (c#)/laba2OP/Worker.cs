
using System;

namespace laba2OP
{
    [Serializable]
    public class Worker
    {
        private string name;
        private string birthday;
        private string dateStartWork;

        public Worker(string a, string b, string c)
        {
            name = a;
            birthday = b;
            dateStartWork = c;
        }

        public Worker()
        {
            name = birthday = dateStartWork = "0";
        }
        public int GetStaj()
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

        public void Print()
        {
            Console.Write(name + "  " + birthday + "  " + dateStartWork+"\n");
        }

        public int GetAge()
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

        public int GetMonth()
        {
            int mm;
            mm = Convert.ToInt32(birthday.Substring(birthday.IndexOf('.') + 1, 2));
            return mm;
        }
    }
}