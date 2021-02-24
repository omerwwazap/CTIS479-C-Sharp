using System;

namespace CTIS479_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Levent Durdalı - Homework 1");
            Console.WriteLine("************\n");

            //2.Add is-a relation between the classes
            //6.Override the base class method in the sub class and from the sub class overridden method, call the base class overridden method.
            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Levent", "Durdalı");
            retailSalesPerson.Sell();
            retailSalesPerson.Car_Develop();

            Console.WriteLine("\n************\n");

            RetailSalesPerson SalesPerson2 = new RetailSalesPerson("Levent", "Durdalı", 50); // 9. Implement at least one method which has optional parameters
            SalesPerson2.Sell();
            SalesPerson2.Car_Develop();

            //15.Create an use tuples
            var car_Properties_Skoda = (Brand: "Skoda", HP: 150, Type: "Hatchback");
            var car_Properties_Seat = (Brand: "Seat", HP: 200, Type: "Coupe");

            string val;
            int exit;
            string choosen = "";
            do
            {
                Console.Write("\nEnter Car Numer to choose: \n");
                Console.Write($"1 - {car_Properties_Skoda.Brand} - {car_Properties_Skoda.HP} - {car_Properties_Skoda.Type}\n");
                Console.Write($"2 - {car_Properties_Seat.Brand} - {car_Properties_Seat.HP} - {car_Properties_Seat.Type}\n");
                Console.Write("9 - to exit\n");
                val = Console.ReadLine();
                exit = Convert.ToInt32(val);
                if (exit == 1)
                {
                    Console.Write("\nChoosen: {0} \n", car_Properties_Skoda.Brand);
                    choosen = car_Properties_Skoda.Brand;
                    break;
                }
                if (exit == 2)
                {
                    Console.Write("\nChoosen: {0} \n", car_Properties_Seat.Brand);
                    choosen = car_Properties_Seat.Brand;
                    break;
                }
            } while (exit != 9);


            Console.WriteLine("\n************\n");
            Address a1 = new Address(addressLine: "Bilkent.....", city: "Ankara", state: "Ankara");
            Location isim1_Loc_now = new Location(100, 0);
            Buyer buys = new Buyer(lastName: "Ömer", firstName: "Levent", address: a1, now: isim1_Loc_now, got_car: false, car_name: choosen); // 10.Call the methods by using the named arguments
            buys.GetFullname();
            buys.Display();

            //Location of Car that is bought
            //13.Create at least one structure and use it in your application.
            Location car_loc = new Location(500, 200);
            Console.WriteLine("The Location of your car is: ");
            car_loc.Display();


            Location distanceto_car = isim1_Loc_now - car_loc;
            Console.WriteLine("Your Distance to your car is: ");
            double distance = Math.Round(Math.Sqrt(Math.Pow((distanceto_car.Y - isim1_Loc_now.Y), 2) + Math.Pow((distanceto_car.X - isim1_Loc_now.X), 2)), 1);
            double distance_from_buyer;
            //19.Create a method(s) with out parameters
            distance_by_meters(distance, 2, out distance_from_buyer);
            Console.WriteLine(distance_from_buyer + "meters.");
            Console.WriteLine("Current Location is: ");
            distanceto_car.Display();

            if (distance_from_buyer.UseBus())
            { // True if value is larger than 300meters
                Console.WriteLine("Pls use a bus");
            }
            else
            {
                Console.WriteLine("The car is near, walking is healty :)");
            }
            //19.Create a method(s) with in parameters
            change_bought(buys);
            buys.Display();

            //19.Create a method(s) with ref parameters
            mixup_inDatabase(ref buys);
            buys.Display();

            Console.WriteLine("\n************\n");
            Re_Helper helper = new Re_Helper("Yardımcı1", "Yardımcı1");
            helper.Sell();







        }
        //19.Create a method(s) with out parameters
        public static void distance_by_meters(double x, int y, out double ans)
        {
            ans = Math.Round(x, y);
        }
        //19.Create a method(s) with in parameters
        public static void change_bought(in Buyer buys)
        {
            buys.got_car = true;
        }
        //19.Create a method(s) with ref, out and in parameters
        public static void mixup_inDatabase(ref Buyer buys)
        {
            buys.address.addressLine = "Lost ERROR";
            buys.address.city = "Lost ERROR";
            buys.address.state = "Lost ERROR";

        }


    }
}
