using System;

namespace СourseWork_SecondRealization
{
    internal class Human
    {
        protected Int32 Age; //Возраст
        protected Int32 Moneybalance; //Игровой баланс
        protected String Name; //Имя
        protected String Sex; //Пол
        protected Int32 Level; //Игровой уровень
        protected MedicalCard MedCard;
        protected Realty realty;
        protected Clothes clothes;
        protected FoodEating food;

        public Human()
        {
            this.Age = 0;
            this.Name = "test";
            this.Moneybalance = 100;
            this.Sex = "test";
            this.Level = 0;
            this.MedCard = new MedicalCard();
            this.realty = new Realty();
            this.clothes = new Clothes();
            this.food = new FoodEating();
        }

        public Int32 GetAge()
        {
            return this.Age;
        }

        public void SetAge(Int32 age)
        {
            this.Age = age;
        }

        public Int32 GetMoneybalance()
        {
            return this.Moneybalance;
        }

        public void SetMoneyBalance(Int32 moneybalance)
        {
            this.Moneybalance = moneybalance;
        }

        public String GetName()
        {
            return this.Name;
        }

        public void SetName(String name)
        {
            this.Name = name;
        }

        public String GetSex()
        {
            return this.Sex;
        }

        public void SetSex(String sex)
        {
            this.Sex = sex;
        }

        public Int32 GetLevel()
        {
            return this.Level;
        }

        public void SetLevel(Int32 level)
        {
            this.Level = level;
        }

        public void LevelUp()
        {
            this.Level++;
        }

        public void ChangeMoney(Int32 money)
        {
            this.Moneybalance += money;
            if (this.Moneybalance < 0)
            {
                this.Moneybalance = 0;
            }
        }

        public MedicalCard GetMedCard()
        {
            return this.MedCard;
        }

        public Realty GetRealty()
        {
            return this.realty;
        }

        public Clothes GetClothes()
        {
            return this.clothes;
        }

        public FoodEating GetFood()
        {
            return this.food;
        }
    }
}
