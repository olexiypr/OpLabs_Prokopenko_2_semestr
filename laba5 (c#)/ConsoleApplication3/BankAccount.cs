using System;

namespace ConsoleApplication3
{
    public abstract class BankAccount //батьківський клас
    {
        private string bankName { get; set; }
        private static int _idCounter;  //поле для задання кожному акаунту унікального номеру
        protected int _id;
        protected bool status;
        public int amountMoney { get; set; }
        protected BankAccount(string bankName)
        {
            this.bankName = bankName;
            status = true;
            _id = _idCounter;
            _idCounter++;
        }
        public abstract void AddMoney(int countMoney); //метод додавання грошей 
        public abstract void WithdrawMoney(int countMoney); //метод зняття грошей
        public override string ToString() //метод для відображення інформації
        {
            return ($"Name: {bankName}, id: {_id}, amount money: {amountMoney}, status: {status}");
        }
    }
}