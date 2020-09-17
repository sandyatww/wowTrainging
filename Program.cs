using System;

namespace tes
{
    class Program
    {
       // public double totalSellSaving,totalMaintenance,ownSaving;
        //public SellExpense sellexp;
        public static void Main(string[] args)
        {
         Decision decision = new Decision();

         // parameter : number of years.
         decision.IsItWorthSellingOrKeeping(5);
        }
    }
}
