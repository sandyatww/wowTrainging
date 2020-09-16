using System;

namespace tes
{
    class Program
    {
       // public double totalSellSaving,totalMaintenance,ownSaving;
        //public SellExpense sellexp;
        public static void Main(string[] args)
        {
            SellExpense sellexp = new SellExpense();
            sellexp.salePriceNow = 720000;
            sellexp.salesCostPercent = 0.03;
            sellexp.pendingMortgage=560500; // I have one one object for SellExpense class
            Console.WriteLine("Money invested is" + sellexp.getExpense());
            double moneyInvested = sellexp.getExpense();
            

            SellInvestment invest = new SellInvestment(moneyInvested, sellexp);
            invest.roiPercentage = 0.12;
            invest.numberOfYears=3;
            double totalSellSaving=invest.getInvestmentPlan();

            OwnExpenses ownexp = new OwnExpenses();
            ownexp.propMaintenance = 5000;
            ownexp.waterRates = 1000;
            ownexp.councilTax = 1800;
            ownexp.insurance = 1500;
            ownexp.mortgageInterest = 22440;
            double totalMaintenance=ownexp.getMaintenanceCost();

            OwnIncome owninc = new OwnIncome();
            owninc.rentAgencyRate = 0.07;
            owninc.yearlyRent = 22560;
            owninc.hikePercent = 0.04;
            double ownSaving=owninc.getOwnSavings();
            double totalOwnSaving=ownSaving-totalMaintenance;
            if (totalSellSaving > totalOwnSaving)
            {
                Console.WriteLine("Sell value" +"is" +moneyInvested + "& Investing for" + invest.numberOfYears +"years will yeild" + totalSellSaving );
                Console.WriteLine("Selling now and investing it in an investment plan is profitable");
            }
            else
            {
                Console.WriteLine("Owning Value is" +" "+  totalOwnSaving);
                Console.WriteLine("Owning is profitable.");
            }
        }
    }
}
