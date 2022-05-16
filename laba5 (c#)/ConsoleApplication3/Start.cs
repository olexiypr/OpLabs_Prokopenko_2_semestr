using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public static class Start
    {
        private static int GetPeriod(List<DepositAccount> arr) //знаходження максимального періоду депозиту
        {
            DepositAccount max = arr[0];
            for (int i = 0; i < arr.Count; i++)
            {
                if (max.CountMonth<arr[i].CountMonth)
                {
                    max = arr[i];
                }
            }

            return max.CountMonth+1;
        }
        public static void StartBanking(List<DepositAccount> depositAccounts, List<CurrentAccount> currentAccounts)
        {
            AddAccounts(depositAccounts, currentAccounts);
            int a = GetPeriod(depositAccounts);
            for (int i = 0; i < a; i++)     //цикл яких симулює поведінку акаунтів за період їх існування
            {
                for (int j = 0; j < depositAccounts.Count; j++)
                {
                    currentAccounts[j].amountOfMoney += depositAccounts[j].AccrualOfInterest(); //перерахунок нарахованих відсотків
                    currentAccounts[j].AddDate(Date.GetDate()); //запис дати операцій
                    Console.WriteLine(currentAccounts[j].ToString());  //виведення інформації в консоль
                    Console.WriteLine(depositAccounts[j].ToString()); //виведення інформації в консоль
                    depositAccounts[j].CountMonth--;  //зменшення на місяць сроку депозиту
                }
                Date.NextMonth(); //наступний місяць
                Console.WriteLine($"After {i} month");
                Console.WriteLine("======================================================");
            }
        }

        private static void AddAccounts(List<DepositAccount> depositAccounts, List<CurrentAccount> currentAccounts) // додавання акаунтів
        {
            Console.WriteLine("For add accounts press 'a'");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
               
                while (true)
                {
                    Console.WriteLine("Enter name bank: ");
                    string nameBank = Console.ReadLine();
                    CurrentAccount cur = new CurrentAccount(nameBank);
                    currentAccounts.Add(cur);
                    DepositAccount dep = new DepositAccount(nameBank);
                    depositAccounts.Add(dep);
                    Console.WriteLine("For add one more account press 'a', for end press 's'");
                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        return;
                    }
                }
            }
        }
    }
}