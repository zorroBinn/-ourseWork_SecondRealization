using System;

namespace СourseWork_SecondRealization
{
    internal class MedicalCard
    {
        private bool InfinityHealth;
        private Int32 Weight;
        private Int32 Height;
        private Int32 HealthStatus;

        public MedicalCard()
        {
            this.Weight = 50;
            this.Height = 170;
            this.HealthStatus = 100;
            this.InfinityHealth = false;
        }

        public Int32 GetWeight()
        {
            return this.Weight;
        }

        public void SetWeight(Int32 weight)
        {
            this.Weight = weight;
        }

        public Int32 GetHeight()
        {
            return this.Height;
        }

        public void SetHeight(Int32 height)
        {
            this.Height = height;
        }

        public Int32 GetHealthStatus()
        {
            return this.HealthStatus;
        }

        public void SetHealthStatus(Int32 status)
        {
            this.HealthStatus = status;
        }

        public void DownStatus()
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

        public void UpStatus()
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

        public bool GetInfinityHealth()
        {
            return this.InfinityHealth;
        }

        public void SetInfinityHealth(bool argument)
        {
            this.InfinityHealth = argument;
            if (this.InfinityHealth == true)
            {
                this.HealthStatus = 100;
            }
        }
    }
}
