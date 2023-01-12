using System;

namespace СourseWork_SecondRealization
{
    internal class Realty
    {
        private String Housing;
        private String Vehicle;

        public Realty()
        {
            this.Housing = "Гараж";
            this.Vehicle = "Велик";
        }

        public String GetHousing()
        {
            return this.Housing;
        }

        public void SetHousing(String housing)
        {
            this.Housing = housing;
        }

        public String GetVehicle()
        {
            return this.Vehicle;
        }

        public void SetVehicle(String vehicle)
        {
            this.Vehicle = vehicle;
        }
    }
}
