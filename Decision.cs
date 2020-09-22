using System;

public class Decision
{
    public void IsItWorthSellingOrKeeping(int numberOfYears)
    {
        SellExpense sellexp = new SellExpense(720000, 0.03, 560500);
        Double MoneyLeftAfterSale = sellexp.MoneyLeftAfterSale();
        SellInvestment invest = new SellInvestment(sellexp, MoneyLeftAfterSale, 0.12, 3);
        Double ReturnFromInvestment = invest.getInvestmentPlan();
        OwnExpenses ownexp = new OwnExpenses(invest);
        Double MaintenanceCost = ownexp.getMaintenanceCost(5000, 1000, 1800, 1500, 22400);
        OwnIncome owninc = new OwnIncome(invest, sellexp);
        Double RentAndHike = owninc.getOwnSavings(22560, 0.07, 0.04);
        Double ProfitOfOwning = RentAndHike - MaintenanceCost;
        if (ReturnFromInvestment > ProfitOfOwning)
        {
            Console.WriteLine("Sell value is" + " " + MoneyLeftAfterSale + " " + "& Investing for"
            + " " + invest.numberOfYears + " " + "years will yeild" + " " + ReturnFromInvestment);
            Console.WriteLine("Selling now and investing it in an investment plan is profitable");
        }
        else
        {
            Console.WriteLine("Owning Value is" + " " + ProfitOfOwning);
            Console.WriteLine("Owning is profitable.");
        }
    }


}