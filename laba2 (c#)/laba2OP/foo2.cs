using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace laba2OP
{
    class Module_Read
    {
        public static int DeSerialize(string nameInput , int size, string nameResult)
        {
            DateTime now = DateTime.Now;
            int month = now.Month, count=0;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(nameInput, FileMode.OpenOrCreate))
            {
                
                for (int i = 0; i < size; i++)
                {
                    Worker some = (Worker) formatter.Deserialize(fs);
                    filter(some, nameResult, month, ref count);
                }
                fs.Close();
            }

            return count;
        }

        private static void filter(Worker some, string nameResult, int month, ref int count)  //запис в файл або виведення на екран
        {
            if (WorkWithStruct.GetStaj(some.dateStartWork) >= 5 && WorkWithStruct.GetMonth(some.birthday) == month)
            {
                WorkWithStruct.Print(some.name, some.birthday, some.dateStartWork);
            }

            if (WorkWithStruct.GetAge(some.birthday)-WorkWithStruct.GetStaj(some.dateStartWork)<=25 && WorkWithStruct.GetStaj(some.dateStartWork)>=10)
            {
                count++;
                Module_Write.writeObjectInFile(some, nameResult);
            }
        }
        public static void printFile(string nameFile, int size)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                for (int i = 0; i < size; i++)
                {
                    Worker some = (Worker) formatter.Deserialize(fs);
                    WorkWithStruct.Print(some.name, some.birthday, some.dateStartWork);
                }
                fs.Close();
            }
        }
    }
}
