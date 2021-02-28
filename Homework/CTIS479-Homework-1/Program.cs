using System;
using System.Collections.Generic;

namespace LeventDurdali_HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Levent Durdalı - Homework 1 - 21702600");
            //Implemented all 21 Items, sorry for bad programming.
            Console.WriteLine("************\n");

            //2.Add is-a relation between the classes
            //6.Override the base class method in the sub class and from the sub class overridden method, call the base class overridden method.
            //5.Call the base class constructor from sub class
            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Levent", "RetailSalesPerson");
            retailSalesPerson.Sell();
            retailSalesPerson.Car_Develop();

            Re_Helper helper = new Re_Helper("Helper-11", "Helper-11");
            Console.WriteLine();
            helper.Sell();

            Console.WriteLine("\n***************\n");


            RetailSalesPerson SalesPerson2 = new RetailSalesPerson("Levent", "SalesPerson", 50); // 9. Implement at least one method which has optional parameters
            SalesPerson2.Sell();
            SalesPerson2.Car_Develop();

            Console.WriteLine("\n************\n");

            //15.Create an use tuples
            var car_Properties_Skoda = (Brand: "Skoda", HP: 150, Type: "Hatchback", price: 100);
            var car_Properties_Seat = (Brand: "Seat", HP: 200, Type: "Coupe", price: 200);

            string val;
            int exit;
            string choosen = "";
            do
            {
                Console.Write("Enter Car Numer to choose: \n");
                Console.Write($"1 - {car_Properties_Skoda.Brand} - {car_Properties_Skoda.HP} - {car_Properties_Skoda.Type} - {car_Properties_Skoda.price}\n");
                Console.Write($"2 - {car_Properties_Seat.Brand} - {car_Properties_Seat.HP} - {car_Properties_Seat.Type} - {car_Properties_Seat.price}\n");
                Console.Write($"3 - Both Cars\n");
                Console.Write("9 - to exit\n");
                val = Console.ReadLine();
                exit = Convert.ToInt32(val);
                if (exit == 1)
                {
                    Console.Write("Choosen: {0} ", car_Properties_Skoda.Brand);
                    choosen = car_Properties_Skoda.Brand;
                    break;
                }
                if (exit == 2)
                {
                    Console.Write("Choosen: {0} ", car_Properties_Seat.Brand);
                    choosen = car_Properties_Seat.Brand;
                    break;
                }
                if (exit == 3)
                {
                    Console.Write("Choosen: {0} ", car_Properties_Seat.Brand);
                    choosen = car_Properties_Skoda.Brand + " and " + car_Properties_Seat.Brand;
                    break;
                }
            } while (exit != 9);

            Console.WriteLine("\n************\n");

            Address buyer1_add = new Address(addressLine: "Bilkent.....", city: "Ankara", state: "Ankara");
            Location buyer_Loc_now = new Location(100, 0);
            // 10.Call the methods by using the named arguments
            Buyer buys = new Buyer(lastName: "Main-Buyer", firstName: "Ömer", address: buyer1_add, now: buyer_Loc_now, got_car: false, car_name: choosen);
            buys.GetFullname();
            buys.Display();

            //Location of Car that is bought
            //13.Create at least one structure and use it in your application.
            Location car_loc = new Location(500, 200);
            Console.WriteLine("The Location of your car is: ");
            car_loc.Display();

            Location distanceto_car = buyer_Loc_now - car_loc;
            Console.WriteLine("Your Distance to your car is: ");
            double distance = Math.Round(Math.Sqrt(Math.Pow((distanceto_car.Y - buyer_Loc_now.Y), 2) + Math.Pow((distanceto_car.X - buyer_Loc_now.X), 2)), 1);
            double distance_from_buyer;
            //19.Create a method(s) with out parameters
            distance_by_meters(distance, 2, out distance_from_buyer);
            Console.WriteLine(distance_from_buyer + " meters.");
            Console.WriteLine("Your Distance in coordinates are: ");
            distanceto_car.Display();

            Console.WriteLine("Since you are over 300 meters away from the car: ");

            //17.Implement at least one extension method
            if (distance_from_buyer.UseBus())
            { // True if value is larger than 300meters
                Console.WriteLine("Please use a bus");
            }
            else
            {
                Console.WriteLine("Please walk, walking is healty :)");
            }

            //20.Create a method(s) so that it can be called with variable length of parameters.
            int cost = 0;
            if (exit == 1)
            {
                cost = Car_cost(car_Properties_Skoda.price);
            }
            else if (exit == 2)
            {
                cost = Car_cost(car_Properties_Seat.price);
            }
            else if (exit == 3)
            {
                cost = Car_cost(car_Properties_Seat.price, car_Properties_Skoda.price);
            }
            Console.WriteLine("The Cost of Your choosen car(s): " + cost);
            Console.WriteLine("************\n");

            //19.Create a method(s) with in parameters

            Console.WriteLine("Showing all related info about the buyer and changing the database to bought");
            change_bought(in buys);
            buys.Display();

            //19.Create a method(s) with ref parameters
            Console.WriteLine("Oh no, an eror happened in the databse");
            mixup_inDatabase(ref buys);
            buys.Display();

            Console.WriteLine("************\n");


            //14.Create at least one enum and use it in your application.
            EmpTypeEnum Helper = EmpTypeEnum.Helper;
            EmpTypeEnum Salesman = EmpTypeEnum.Salesman;
            EmpTypeEnum Customer = EmpTypeEnum.Customer;

            string val2;
            int exit2;
            do
            {
                Console.Write("Time For feed back choose your occupation: \n");
                Console.Write($"1 - Customer\n");
                Console.Write($"2 - Helper\n");
                Console.Write($"3 - Salesman\n");
                Console.Write("9 - to exit\n");
                val2 = Console.ReadLine();
                exit2 = Convert.ToInt32(val);
                if (exit2 == 1)
                {
                    Survay_toUsers(Customer);
                    break;
                }
                if (exit2 == 2)
                {
                    Survay_toUsers(Helper);
                    break;
                }
                if (exit2 == 3)
                {
                    Survay_toUsers(Salesman);
                    break;
                }
            } while (exit != 9);

            Console.WriteLine("************\n");

            //12.Create a static class with static constructor. This static constructor can be used to add objects to the collection. (Static constructor is in Buyer Class)
            BuyerCollection buyerCollection = new BuyerCollection();
            buyerCollection[0] = new Buyer("Ahmet", "New Buyer");
            buyerCollection[1] = new Buyer("Furkan", "New New Buyer");
            Console.WriteLine("Number of new People looking for cars is: " + buyerCollection.Count);
            for (int i = 0; i < buyerCollection.Count; i++)
                Console.WriteLine("Person number: {0} {1}", i + 1, buyerCollection[i].Fullname);

            Console.WriteLine("\n************\n");

            //11.Use at least one generic collection and display the sorted output
            List<string> FullNames = new List<string>();
            FullNames.Add(SalesPerson2.Fullname);
            FullNames.Add(retailSalesPerson.Fullname);
            FullNames.Add(buys.Fullname);
            FullNames.Add(buyerCollection[0].Fullname);
            FullNames.Add(buyerCollection[1].Fullname);
            FullNames.Sort();
            Console.WriteLine("Number of People that interacted with another + the Number of new People looking for cars is: " + FullNames.Count);
            int inum = 1;
            foreach (var el in FullNames)
            {
                Console.WriteLine("Person number: {0} - {1}", inum, el);
                inum++;
            }
        }


        enum EmpTypeEnum
        {
            Helper,
            Salesman,
            Customer,
        }
        static void Survay_toUsers(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Helper:
                    Console.WriteLine("Congrats you recived a 5/5 stars from the Customer(buyer)\n");
                    break;
                case EmpTypeEnum.Salesman:
                    Console.WriteLine("Sorry the Customer(buyer) didnt like you, 0/5 stars\n");
                    break;
                case EmpTypeEnum.Customer:
                    Console.WriteLine("Have a nice day\n");
                    break;
            }
        }

        public static int Car_cost(params int[] b)
        {
            int mul = 0;
            foreach (int a in b)
            {
                mul = mul + a;
            }
            return mul;
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
            buys.got_car = false;
            buys.now.Y = 999;
            buys.now.X = -999;
        }


    }
}
