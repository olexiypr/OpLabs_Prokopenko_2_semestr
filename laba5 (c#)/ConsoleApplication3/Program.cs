using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<CurrentAccount> currentAccounts = new List<CurrentAccount>() //створення списку розрахункових рахунків
            {
                new CurrentAccount("Privat", 10000),
                new CurrentAccount("Mono", 20000),
                new CurrentAccount("Alfa", 50000)
            };
            List<DepositAccount> depositAccounts = new List<DepositAccount>() //створення списку депозитних акаунтів
            {
                new DepositAccount("Privat", 12, 25000),
                new DepositAccount("Mono", 6, 30000),
                new DepositAccount("Alfa", 15, 65000)
            };
            Start.StartBanking(depositAccounts, currentAccounts); //метод який симулює поведінку акаунтів в період дії депозитних акаунтів
        }
    }
}