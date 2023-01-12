using System;

namespace СourseWork_SecondRealization
{
    internal class MedicalCard //Класс "Медицинская карта"
    {
        private bool InfinityHealth; //Показатель бесконечного здоровья (автолечения)
        private Int32 Weight; //Вес
        private Int32 Height; //Рост
        private Int32 HealthStatus; //Статус здоровья (0-100)

        public MedicalCard() //Конструктор без параметров
        {
            this.Weight = 50;
            this.Height = 170;
            this.HealthStatus = 100;
            this.InfinityHealth = false;
        }

        public Int32 GetWeight() //Геттер веса
        {
            return this.Weight;
        }

        public void SetWeight(Int32 weight) //Сеттер веса
        {
            this.Weight = weight;
        }

        public Int32 GetHeight() //Геттер роста
        {
            return this.Height;
        }

        public void SetHeight(Int32 height) //Сеттер роста
        {
            this.Height = height;
        }

        public Int32 GetHealthStatus() //Геттер статуса здоровья
        {
            return this.HealthStatus;
        }

        public void SetHealthStatus(Int32 status) //Сеттер статуса здоровья
        {
            this.HealthStatus = status;
        }

        public void DownStatus() //Метод "Уменьшить статус здоровья"
        {
            if (this.HealthStatus > 0)
            {
                this.HealthStatus -= 5;
                if (this.HealthStatus < 0)
                {
                    this.HealthStatus = 0;
                }
            }
        }

        public void UpStatus() //Метод "Поднять статус здоровья"
        {
            if (this.HealthStatus < 100)
            {
                this.HealthStatus += 35;
                if (this.HealthStatus > 100)
                {
                    this.HealthStatus = 100;
                }
            }
        }

        public bool GetInfinityHealth() //Геттер показателя бесконечного здоровья (автолечения)
        {
            return this.InfinityHealth;
        }

        public void SetInfinityHealth(bool argument) //Сеттер показателя бесконечного здоровья (автолечения)
        {
            this.InfinityHealth = argument;
            if (this.InfinityHealth == true)
            {
                this.HealthStatus = 100;
            }
        }
    }
}
