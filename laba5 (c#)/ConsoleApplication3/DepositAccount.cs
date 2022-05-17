using System;

namespace ConsoleApplication3
{
    public class DepositAccount : BankAccount
    {
        private int countMonth;
        private double countPercent { get; set; }
        public int amountOfMoney { get; set; }
        public int CountMonth
        {
            get => countMonth;
            set
            {
                if (countMonth==0 && value!=0)  //для коректного відображення кількості місяців до закінчення депозиту
                {
                    countMonth = 0;
                }
                else
                {
                    countMonth = value;
                }
            }
        }

        public DepositAccount(string name) : base(name)  //конструктор якйи використовується при додаванні акаутнів через консоль
        {
            Console.WriteLine("How much money do you want to put into the deposit: ");
            amountOfMoney = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter period: ");
            countMonth = Int32.Parse(Console.ReadLine());
            countPercent = Percent();
        }
        public DepositAccount(string name, int countMonth, int amountOfMoney) : base(name)
        {
            this.countMonth = countMonth;
            this.amountOfMoney = amountOfMoney;
            countPercent = Percent();
        }
        private double Percent()  //метод для підрахунку відсотків залежно від періоду
        { 
            if (countMonth>1 && countMonth <=6)
            {
                countPercent = 5;
            }else if (countMonth>6 && countMonth<=12)
            {
                countPercent = 7;
            }else if (countMonth>12 && countMonth<24)
            { 
                countPercent = 8.5;
            }
            else
            {
                countPercent = 9;
            }
            return countPercent;
        }

        public int AccrualOfInterest() //кількість грошей нарахованих за місяць
        {
            if (countMonth==0)
            {
                status = false;
                int temp = amountOfMoney;
                amountOfMoney = 0;
                return temp;
            }
            return (int)(amountOfMoney * (countPercent / 100));
        }

        public override void AddMoney(int countMoney) //додавання грошей
        {
            amountOfMoney += countMoney;
        }

        public override void WithdrawMoney(int countMoney)
        {
            amountOfMoney -= countMoney;
        }

        public override string ToString() //виведення інформації
        {
            return ($"Deposit account: ID: {_id} count month: {countMonth}, amount money: {amountOfMoney}, percent: {countPercent} status: {status}");
        }
    }
}