
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using laba2OP;
using foo2;
namespace foo
{
    class Module_Write
    {
        public static int addWorker(string nameFile, int count)
        {
            int a;
            Console.WriteLine("Якщо ви хочете додати працівників натисніть 1: ");
            a=Convert.ToInt32(Console.ReadLine());
            if (a==1)
            {
                string rez;
                while (true)
                {
                    count++;
                    rez = Console.ReadLine();
                    if (rez == string.Empty)
                    {
                        return count-1;
                    }
                    else
                    {
                        string name, brd, date;
                        name = rez.Substring(0, rez.IndexOf(' '));
                        brd = rez.Substring(rez.IndexOf(' ') + 1, 10);
                        date = rez.Substring((rez.LastIndexOf(' ') + 1));
                        Worker some = new Worker(name,brd,date);
                        writeObjectInFile(some, nameFile);
                    }
                }
            }
            return count;
        }
        public static void writeObjectInFile(Worker some, string name)
        {
            BinaryFormatter write = new BinaryFormatter();
            using (FileStream fs=new FileStream(name, FileMode.OpenOrCreate | FileMode.Append)) 
            {
                write.Serialize(fs, some);
                fs.Close();
            }
        }

        public static void cleanFile(string name)
        {
            FileStream del = new FileStream(name, FileMode.Truncate);
            del.Close();
        }
    }
}















