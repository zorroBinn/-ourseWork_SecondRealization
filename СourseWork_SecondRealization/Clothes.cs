using System;

namespace СourseWork_SecondRealization
{
    internal class Clothes
    {
        private bool AutoSewUp;
        private String Body;
        private String Pants;
        private String Shoes;
        private Int32 ClothesStatus;

        public Clothes()
        {
            SetRegularClothes();
            this.AutoSewUp = false;
        }

        public String GetBody()
        {
            return this.Body;
        }

        public void SetBody(String body)
        {
            this.Body = body;
        }

        public String GetPants()
        {
            return this.Pants;
        }

        public void SetPants(String pants)
        {
            this.Pants = pants;
        }

        public String GetShoes()
        {
            return this.Shoes;
        }

        public void SetShoes(String shoes)
        {
            this.Shoes = shoes;
        }

        public Int32 GetClothesStatus()
        {
            return this.ClothesStatus;
        }

        public void SetClothesStatus(Int32 status)
        {
            this.ClothesStatus = status;
        }

        public void SewUpClothes()
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

        public void TearClothes()
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

        public void BuySuit()
        {
            this.Body = "Пиджак";
            this.Pants = "Брюки";
            this.Shoes = "Туфли";
            this.ClothesStatus = 100;
        }

        public void SetRegularClothes()
        {
            this.Body = "Кофта";
            this.Pants = "Джинсы";
            this.Shoes = "Кроссовки";
            this.ClothesStatus = 100;
        }

        public bool GetAutoSewUp()
        {
            return this.AutoSewUp;
        }

        public void SetAutoSewUp(bool argument)
        {
            this.AutoSewUp = argument;
            if (this.AutoSewUp == true)
            {
                this.ClothesStatus = 100;
            }
        }
    }
}
