using System;

namespace СourseWork_SecondRealization
{
    internal class Realty //Класс "Имущество"
    {
        private String Housing; //Недвижимость
        private String Vehicle; //Транспортное средство

        public Realty() //Конструктор без параметров
        {
            this.Housing = "Гараж";
            this.Vehicle = "Велик";
        }

        public String GetHousing() //Геттер недвижимости
        {
            return this.Housing;
        }

        public void SetHousing(String housing) //Сеттер недвижимости
        {
            this.Housing = housing;
        }

        public String GetVehicle() //Геттер транспортного средства
        {
            return this.Vehicle;
        }

        public void SetVehicle(String vehicle) //Сеттер транспортного средства
        {
            this.Vehicle = vehicle;
        }
    }
}
