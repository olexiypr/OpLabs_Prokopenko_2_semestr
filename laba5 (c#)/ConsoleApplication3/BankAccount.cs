using System;

namespace ConsoleApplication3
{
    public class BankAccount //батьківський клас
    {
        private string bankName { get; set; }
        private static int _idCounter;  //поле для задання кожному акаунту унікального номеру
        protected int _id;
        protected bool status;
        public int amountMoney { get; set; }
        public BankAccount(string bankName)
        {
            this.bankName = bankName;
            status = true;
            _id = _idCounter;
            _idCounter++;
        }
        
        public virtual void AddMoney(int countMoney) //метод додавання грошей 
        {
            amountMoney += countMoney;
        }
        
        public virtual void WithdrawMoney(int countMoney) //метод зняття грошей
        {
            if (amountMoney>=countMoney)
            {
                amountMoney -= countMoney;
            }
            else
            {
                Console.WriteLine("Недостаточно денег на счету");
            }
        }
        
        public override string ToString() //метод для відображення інформації
        {
            return ($"Name: {bankName}, id: {_id}, amount money: {amountMoney}, status: {status}");
        }
    }
}