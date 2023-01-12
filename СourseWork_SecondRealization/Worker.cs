using System;

namespace СourseWork_SecondRealization
{
    internal class Worker : Human //Класс "Работник" - наследуется от класса "Человек"
    {
        private String Namework; //Наименование работы
        private Int32 Payment; //Оплата

        public Worker() : base() //Конструктор без параметров
        {
            this.Namework = "Раздача листовок";
            this.Payment = 10;
        }

        public Int32 GetPayment() //Геттер оплаты
        {
            return this.Payment;
        }

        public void SetPayment(Int32 payment) //Сеттер оплаты
        {

            this.Payment = payment;
        }

        public String GetNamework() //Геттер наименования работы
        {

            return this.Namework;
        }

        public void SetNamework(String nameWork) //Сеттер наименования работы
        {

            this.Namework = nameWork;
        }

    }
}
