using System;

namespace СourseWork_SecondRealization
{
    internal class Clothes //Класс "Одежда"
    {
        private bool AutoSewUp; //Показатель автопочинки одежды
        private String Body; //Верх одежды
        private String Pants; //Штаны
        private String Shoes; //Обувь
        private Int32 ClothesStatus; //Статус целостности одежды (0-100)

        public Clothes() //Конструктор без параметров
        {
            SetRegularClothes();
            this.AutoSewUp = false;
        }

        public String GetBody() //Геттер верха одежды
        {
            return this.Body;
        }

        public void SetBody(String body) //Сеттер верха одежды
        {
            this.Body = body;
        }

        public String GetPants() //Геттер штанов
        {
            return this.Pants;
        }

        public void SetPants(String pants) //Сеттер штанов
        {
            this.Pants = pants;
        }

        public String GetShoes() //Геттер обуви
        {
            return this.Shoes;
        }

        public void SetShoes(String shoes) //Сеттер обуви
        {
            this.Shoes = shoes;
        }

        public Int32 GetClothesStatus() //Геттер статуса целостности одежды
        {
            return this.ClothesStatus;
        }

        public void SetClothesStatus(Int32 status) //Сеттер целостности одежды
        {
            this.ClothesStatus = status;
        }

        public void SewUpClothes() //Метод "Починка одежды"
        {
            if (this.ClothesStatus < 100)
            {
                this.ClothesStatus += 20;
                if (this.ClothesStatus > 100)
                {
                    this.ClothesStatus = 100;
                }
            }
        }

        public void TearClothes() //Метод "Порвать одежду"
        {
            if (this.Pants != "Брюки")
            {
                this.ClothesStatus -= 5;
            }
            else
            {
                this.ClothesStatus -= 3;
            }
            if (this.ClothesStatus < 0)
            {
                this.ClothesStatus = 0;
            }
        }

        public void BuySuit() //Метод "Купить костюм"
        {
            this.Body = "Пиджак";
            this.Pants = "Брюки";
            this.Shoes = "Туфли";
            this.ClothesStatus = 100;
        }

        public void SetRegularClothes() //Сеттер стандартной одежды
        {
            this.Body = "Кофта";
            this.Pants = "Джинсы";
            this.Shoes = "Кроссовки";
            this.ClothesStatus = 100;
        }

        public bool GetAutoSewUp() //Геттер показателя автопочинки одежды
        {
            return this.AutoSewUp;
        }

        public void SetAutoSewUp(bool argument) //Сеттер показателя автопочинки одежды
        {
            this.AutoSewUp = argument;
            if (this.AutoSewUp == true)
            {
                this.ClothesStatus = 100;
            }
        }
    }
}
