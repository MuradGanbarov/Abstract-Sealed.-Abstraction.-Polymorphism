//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract__Sealed._Abstraction._Polymorphism
//{
//    public class Colored
//    {
//        public static void Sentence (string text, ConsoleColor color)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine(text);
//            Console.ResetColor();
//        }

//        public static void Accepted(string text, ConsoleColor color)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(text);
//            Console.ResetColor();

//        }


//        public static void Wrong(string text, ConsoleColor color)
//        {
//            Console.ForegroundColor = ConsoleColor.Red ;
//            Console.WriteLine(text);
//            Console.ResetColor();

//        }


//        public static void RunProgram()
//        {
//            Car car = new Car();

//            while (true)
//            {
//                Console.WriteLine("Bakda ne qeder benzin var?" + " " + car.Fuel);
//                Console.WriteLine("Mashinin bakin hecmi ne qederdir?" + " " + car.TankCapacity);
//                Console.WriteLine("Mashin 100 km ne qeder benzin yandirir" + " " + car.fuelNeeded);
//                Console.WriteLine("1. Sur");
//                Console.WriteLine("2. Zapravkaya gir");
//                Console.WriteLine("3. Benzini goster");
//                Console.WriteLine("4. Getdyimiz yolu goster");
//                Console.Write("Enter your choice: ");
//                int choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Neche kilometr yol getmisiz?: ", ConsoleColor.Yellow);
//                        double distance = double.Parse(Console.ReadLine());
//                        if (car.Drive(distance))
//                            Console.WriteLine("Ughurla surduz yolu " + " " + distance + " " + " kilometr" + "\n Bakda qalan benzin" + "=" + car.Fuel, ConsoleColor.Red);

//                        else
//                            Console.WriteLine("Bu yolu getmek mumkun deir.", ConsoleColor.Red);
//                        break;

//                    case 2:
//                        Console.Write("SOCAR-a xosh gelmisiz" + "\n Ne qeder dolduraq?" , ConsoleColor.Yellow);
//                        double refuelAmount = double.Parse(Console.ReadLine());
//                        if (car.Refuel(refuelAmount))
//                            Console.WriteLine("Doldu" + " " + refuelAmount + " " + "benzin.", ConsoleColor.Green);
//                        else
//                            Console.WriteLine("Bak doludu. Artiq doldurmaq mumkun deir.", ConsoleColor.Red);
//                        break;

//                    case 3:
//                        Console.WriteLine("Benzini goster" + " " + car.Fuel, ConsoleColor.Green);
//                        break;

//                    case 4:
//                        Console.WriteLine("Getdiyimiz yol:" + " " + car.MileAge, ConsoleColor.Green);
//                        break;


//                }
//            }

//        }
//    }
//}
