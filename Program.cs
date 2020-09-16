﻿using System;

namespace wowTrainging
{
    class Program
    {
        static void Main(string[] args)
        {

            /* User u = new User();
           Home h = new Home();

           u.Location = "Strathfield";
           u.Name = "Reshmi";
           h.PrintDetails(u);

           u.Location = "Burwood";
           h.PrintDetails(u.Location); */

            Selling s = new Selling(1);
            s.SalePriceNow = 720000;
            s.SalesCostPercentage = 3;
            s.PendingMortgage = 560500;
            s.ROI = 12;

            Console.WriteLine("The money gained on Selling the property in 1 year is " + s.GetMoneyGainedOnSelling());
            Selling s1 = new Selling(3);
            s1.SalePriceNow = 720000;
            s1.SalesCostPercentage = 3;
            s1.PendingMortgage = 560500;
            s1.ROI = 12;
            Console.WriteLine("The money gained on Selling the property in 3 years is " + s1.GetMoneyGainedOnSelling());
            Selling s2 = new Selling(5);
            s2.SalePriceNow = 720000;
            s2.SalesCostPercentage = 3;
            s2.PendingMortgage = 560500;
            s2.ROI = 12;
            Console.WriteLine("The money gained on Selling the property in 5 years is " + s2.GetMoneyGainedOnSelling());
            double a = s2.GetMoneyGainedOnSelling();

            Owning o = new Owning(1);
            o.yearlyloss = 33319.2;
            o.SalePriceNow = 720000;
            o.propertyhike = 4;
            o.SalesCostPercentage = 3;
            o.lessmortage = 560500;
            Console.WriteLine("The money gained on Owning the property in 1 year is " + o.MoneyGainedOnOwning());
            Owning o1 = new Owning(3);
            o1.yearlyloss = 33319.2;
            o1.SalePriceNow = 720000;
            o1.propertyhike = 4;
            o1.SalesCostPercentage = 3;
            o1.lessmortage = 560500;
            Console.WriteLine("The money gained on Owning the property in 3 year is " + o1.MoneyGainedOnOwning());

            Owning o2 = new Owning(5);
            o2.yearlyloss = 33319.2;
            o2.SalePriceNow = 720000;
            o2.propertyhike = 4;
            o2.SalesCostPercentage = 3;
            o2.lessmortage = 560500;
            Console.WriteLine("The money gained on Owning the property in 3 year is " + o2.MoneyGainedOnOwning());
            double b = o2.MoneyGainedOnOwning();

            if (a < b)
            {
                Console.WriteLine("Hello Sandeep, Please own the property for benefit. Good Luck! ");
            }
            else
            {
                Console.WriteLine("Hello Sandeep, Please sell the property for benefit. Good Luck! ");

            }
        }
    }
}
