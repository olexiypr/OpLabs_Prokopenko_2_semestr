using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class CurrentAccount : BankAccount
    {
        public int amountOfMoney { get; set; }
        private List<string> dateTimes; //список операцій

        public CurrentAccount(string name) : base(name) //конструктор якйи використовується при додаванні акаутнів через консоль
        {
            Console.WriteLine("How much money do you want to put into the current account");
            amountOfMoney = Int32.Parse(Console.ReadLine());
            dateTimes = new List<string>();
        }
        public CurrentAccount(string name, int amountOfMoney) : base(name)
        {
            this.amountOfMoney = amountOfMoney;
            dateTimes = new List<string>();
        }
        public void AddDate(string date) //додавання дати останньої операції в список
        {
            dateTimes.Add(date);
        }
        public override void AddMoney(int countMoney) //метод додавання грошей 
        {
            amountOfMoney += countMoney;
        }

        public override void WithdrawMoney(int countMoney) //метод зняття грошей
        {
            amountOfMoney -= countMoney;
        }
        public override string ToString()
        {
            return ($"Current account: ID: {_id} amount of money: {amountOfMoney}, date last operation: {dateTimes[dateTimes.Count-1]}");
        }
    }
}