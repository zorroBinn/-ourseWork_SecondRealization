using System;

namespace СourseWork_SecondRealization
{
    internal class Human //Класс "Человек"
    {
        protected Int32 Age; //Возраст
        protected Int32 Moneybalance; //Игровой баланс
        protected String Name; //Имя
        protected String Sex; //Пол
        protected Int32 Level; //Игровой уровень
        protected MedicalCard MedCard; //Медицинская карта человека
        protected Realty realty; //Имущество человека
        protected Clothes clothes; //Одежда человека
        protected FoodEating food; //Питание человека

        public Human() //Конструктор без параметров
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

        public Int32 GetAge() //Геттер возраста
        {
            return this.Age;
        }

        public void SetAge(Int32 age) //Сеттер возраста
        {
            this.Age = age;
        }

        public Int32 GetMoneybalance() //Геттер баланса
        {
            return this.Moneybalance;
        }

        public void SetMoneyBalance(Int32 moneybalance) //Сеттер баланса
        {
            this.Moneybalance = moneybalance;
        }

        public String GetName() //Геттер имени
        {
            return this.Name;
        }

        public void SetName(String name) //Сеттер имени
        {
            this.Name = name;
        }

        public String GetSex() //Геттер пола
        {
            return this.Sex;
        }

        public void SetSex(String sex) //Сеттер пола
        {
            this.Sex = sex;
        }

        public Int32 GetLevel() //Геттер уровня
        {
            return this.Level;
        }

        public void SetLevel(Int32 level) //Сеттер уровня
        {
            this.Level = level;
        }

        public void LevelUp() //Метод "Повышение уровня"
        {
            this.Level++;
        }

        public void ChangeMoney(Int32 money) //Метод "Изменить баланс денег"
        {
            this.Moneybalance += money;
            if (this.Moneybalance < 0)
            {
                this.Moneybalance = 0;
            }
        }

        public MedicalCard GetMedCard() //Геттер медицинской карты
        {
            return this.MedCard;
        }

        public Realty GetRealty() //Геттер имущества
        {
            return this.realty;
        }

        public Clothes GetClothes() //Геттер одежды
        {
            return this.clothes;
        }

        public FoodEating GetFood() //Геттер питания
        {
            return this.food;
        }
    }
}
