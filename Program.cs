using System;

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
            s.GetSalesCost();
            s.GetMoneyLeft();
            s.GetMoneyGainedOnSelling();
            Console.WriteLine("The money gained on Selling in 1 year is " +s.GetMoneyGainedOnSelling() );
           

    




        }
    }
}
