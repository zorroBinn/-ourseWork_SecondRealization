using System;

namespace СourseWork_SecondRealization
{
    internal class FoodEating
    {
        private bool AutoEating; //Показатель автоматического питания
        private Int32 SatietyStatus; //Статус сытости (0-100)

        public FoodEating() //Конструктор без параметров
        {
            this.AutoEating = false;
            this.SatietyStatus = 100;
        }

        public bool GetAutoEating() //Геттер показателя автоматического питания
        {
            return this.AutoEating;
        }

        public void SetAutoEating(bool argument) //Сеттер показателя автоматического питания
        {
            this.AutoEating = argument;
            if (this.AutoEating == true)
            {
                this.SatietyStatus = 100;
            }
        }

        public Int32 GetSatietyStatus() //Геттер статуса сытости
        {
            return this.SatietyStatus;
        }

        public void SetSatietyStatus(Int32 argument) //Сеттер статуса сытости
        {
            this.SatietyStatus = argument;
        }

        public void UpSatietyStatus(Int32 argument) //Метод "Поднять статус сытости"
        {
            this.SatietyStatus += argument;
            if (this.SatietyStatus > 100)
            {
                this.SatietyStatus = 100;
            }
        }

        public void DownSatietyStatus() //Метод "Уменьшить статус сытости"
        {
            this.SatietyStatus -= 10;
            if (this.SatietyStatus < 0)
            {
                this.SatietyStatus = 0;
            }
        }
    }
}
