using System;
using System.Linq;
using System.IO;
using System.Collections;

namespace Interface_LabAss
{
    interface IVehicle
    {
        public void Drive();
        public bool Refuel(int amount);
    }

    class Car : IVehicle
    {
        private int starting_gasAmount;
        public Car(int starting_amount)
        {
            starting_gasAmount = starting_amount;
        }

       public void Drive()
       {
            if (starting_gasAmount > 0)
            {
                Console.WriteLine("The car is Driving!");
            }
            else 
            {
                Console.WriteLine("Car has stopped working!");
            }
       }

       public bool Refuel(int amount)
       {
            starting_gasAmount = starting_gasAmount + amount;
            return true;
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Car objcar = new Car(0);
            Console.WriteLine("Input an amount to Refuel: ");
            amount = Convert.ToInt32(Console.ReadLine());
            objcar.Refuel(amount);
            objcar.Drive();
        }
    }
}
