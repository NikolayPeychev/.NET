using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Demo1
    {
        public class Car
        {
            private float fuelLeft;
            private float fuelPerMile;
            private float kilometers;

            public Car(float fuelLeft, float fuelPerMile)
            {
                if (fuelLeft < 1)
                {
                    throw new ArgumentException("Negative Fuel Number! Fuel number must be more then 0");
                }
                this.fuelLeft = fuelLeft;

                if (fuelPerMile < 1)
                {
                    throw new ArgumentException("Fuel number must be more then 0");
                }
                this.fuelPerMile = fuelPerMile;
            }

            public float Mileage()
            {
                kilometers = this.fuelLeft / this.fuelPerMile;
                return kilometers;
            }
        }
    }

