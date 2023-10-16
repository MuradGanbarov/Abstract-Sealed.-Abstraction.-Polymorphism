//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract__Sealed._Abstraction._Polymorphism
//{
//    public class Car : IVehicle
//    {

//        public double MileAge { get; private set; }
//        public double Fuel { get; private set; }
//        public double FuelConsumption { get; private set; }
//        public double TankCapacity { get; private set; }

//        public Car(double fuel = 20, double fuelconsumption = 10, double tankcapacity = 40)
//        {
//            Fuel = fuel;
//            FuelConsumption = fuelconsumption;
//            TankCapacity = tankcapacity;
//        }

//        public double fuelNeeded;

//        public bool Drive(double kilometrs)
//        {
//            fuelNeeded = kilometrs/FuelConsumption;
//            if (Fuel >= fuelNeeded)
//            {
                
//                MileAge += kilometrs;
//                Fuel -= fuelNeeded;
//                return true;
//            }
//            return false;
//        }

//        public bool Refuel(double amount)
//        {
//            if (Fuel + amount <= TankCapacity)
//            {
//                Fuel += amount;
//                return true;
//            }
//            return false;


//        }

//    }
//}
