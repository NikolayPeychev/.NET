using System;

namespace Demo1
{
    public class Demo1
    {
        public static void Main()
        {

            while (true)
            {
                Console.Write("Please, enter the fuel ammount: ");
                var fuelLeft = float.Parse(Console.ReadLine());
                Console.Write("Please, enter the fuel per mile: ");
                var fuelPerMile = float.Parse(Console.ReadLine());

                try
                {
                    Car opel = new Car(fuelLeft, fuelPerMile);
                    Console.WriteLine("You can drive {0} km", opel.Mileage());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}


