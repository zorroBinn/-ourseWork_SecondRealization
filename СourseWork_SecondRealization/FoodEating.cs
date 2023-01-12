using System;

namespace СourseWork_SecondRealization
{
    internal class FoodEating
    {
        private bool AutoEating;
        private Int32 SatietyStatus;

        public FoodEating()
        {
            this.AutoEating = false;
            this.SatietyStatus = 100;
        }

        public bool GetAutoEating()
        {
            return this.AutoEating;
        }

        public void SetAutoEating(bool argument)
        {
            this.AutoEating = argument;
            if (this.AutoEating == true)
            {
                this.SatietyStatus = 100;
            }
        }

        public Int32 GetSatietyStatus()
        {
            return this.SatietyStatus;
        }

        public void SetSatietyStatus(Int32 argument)
        {
            this.SatietyStatus = argument;
            if (this.AutoEating == true)
            {
                this.SatietyStatus = 100;
            }
        }

        public void UpSatietyStatus(Int32 argument)
        {
            this.SatietyStatus += argument;
            if (this.SatietyStatus > 100)
            {
                this.SatietyStatus = 100;
            }
        }

        public void DownSatietyStatus()
        {
            this.SatietyStatus -= 10;
            if (this.SatietyStatus < 0)
            {
                this.SatietyStatus = 0;
            }
        }
    }
}
