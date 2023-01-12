using System;

namespace СourseWork_SecondRealization
{
    internal class Worker : Human
    {
        private String Namework;
        private Int32 Payment;

        public Worker() : base()
        {
            this.Namework = "Раздача листовок";
            this.Payment = 10;
        }

        public Int32 GetPayment()
        {
            return this.Payment;
        }

        public void SetPayment(Int32 payment)
        {

            this.Payment = payment;
        }

        public String GetNamework()
        {

            return this.Namework;
        }

        public void SetNamework(String nameWork)
        {

            this.Namework = nameWork;
        }

    }
}
