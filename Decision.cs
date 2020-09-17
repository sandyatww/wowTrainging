using System;

public class Decision
{
  SellExpense sellexp = new SellExpense();
  public void IsItWorthSellingOrKeeping(int numberOfYears)
  {
    Double MoneyLeftAfterSale= sellexp.MoneyLeftAfterSale(720000, 0.03, 560500);

  
            SellInvestment invest = new SellInvestment(moneyInvested, sellexp);
            invest.roiPercentage = 0.12;
            invest.numberOfYears=3;
            double totalSellSaving=invest.getInvestmentPlan();

            OwnExpenses ownexp = new OwnExpenses(invest);
            ownexp.propMaintenance = 5000;
            ownexp.waterRates = 1000;
            ownexp.councilTax = 1800;
            ownexp.insurance = 1500;
            ownexp.mortgageInterest = 22440;
            double totalMaintenance=ownexp.getMaintenanceCost();

            OwnIncome owninc = new OwnIncome(invest, sellexp);
            owninc.rentAgencyRate = 0.07;
            owninc.yearlyRent = 22560;
            owninc.hikePercent = 0.04;
            double ownSaving=owninc.getOwnSavings();
            double totalOwnSaving=ownSaving-totalMaintenance;
            if (totalSellSaving > totalOwnSaving)
            {
                Console.WriteLine("Sell value is" +" " + moneyInvested +" "+ "& Investing for" + invest.numberOfYears + " "+"years will yeild" +" "+ totalSellSaving );
                Console.WriteLine("Selling now and investing it in an investment plan is profitable");
            }
            else
            {
                Console.WriteLine("Owning Value is" +" "+  totalOwnSaving);
                Console.WriteLine("Owning is profitable.");
            }
  }

  
}