using System;

namespace CTIS479_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Levent Durdalı - Homework 1");
            Console.WriteLine("************\n");

            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Levent", "Durdalı");
            retailSalesPerson.Sell();
            retailSalesPerson.Car_Develop();

            Console.WriteLine("\n************\n");

            RetailSalesPerson SalesPerson2 = new RetailSalesPerson("Levent", "Durdalı",50);
            SalesPerson2.Sell();
            SalesPerson2.Car_Develop();

            Console.WriteLine("\n************\n");

            Buyer buys = new Buyer(lastName:"isim1",firstName:"isim2");
            buys.GetFullname();


        }
    }
}
