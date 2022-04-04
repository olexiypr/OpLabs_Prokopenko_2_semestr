﻿using System.Data.Common;
using System;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using foo;
using laba2OP;

namespace foo2
{
    class Module_Read
    {
        public static int DeSer(string nameInput , int size, string nameResult)
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

        private static void filter(Worker some, string nameResult, int month, ref int count)
        {
            if (some.GetStaj() >= 5 && some.GetMonth() == month)
            {
                some.Print();
            }

            if (some.GetAge()-some.GetStaj()<=25 && some.GetStaj()>=10)
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
                    some.Print();
                }
                fs.Close();
            }
        }
    }
}