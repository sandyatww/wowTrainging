using System;
using tes;
public class OwnIncome
{
    public double rentAgencyRate { get; set; }
    public double yearlyRent { get; set; }

    public int numberOfYears { get; set; }

    public double hikePercent { get; set; }
    public double salePriceNow { get; set; }
    public double power { get; set; }
    SellInvestment sellinvest;
    SellExpense sellexp1;
    public OwnIncome(SellInvestment invest, SellExpense sellexp)
    {
        sellinvest = invest;
        sellexp1=sellexp;
    }
    public double getRentIncome()
    {
        double agencyFees = yearlyRent * rentAgencyRate;
        double income = (yearlyRent - agencyFees) * sellinvest.numberOfYears;
        return income;
    }

    public double getPropertyHike()
    {
        double currentPropertyValue=0;
        if (numberOfYears > 0)
        {
            double body = 1 + (hikePercent / 12);
            double exponent = 12 * sellinvest.numberOfYears;
            double power = Math.Pow(body, exponent);
            currentPropertyValue = sellexp1.salePriceNow + (sellexp1.salePriceNow * power);
            Console.WriteLine("The current property value is" + " " + currentPropertyValue);

        }
        else
        {
            Console.WriteLine("The current property value is" + " " + sellexp1.salePriceNow);
        }

        return currentPropertyValue;
    }
    public double getOwnSavings()
    {

        double rentValue = getRentIncome();
        double hikeValue = getPropertyHike();
        double ownSavings = rentValue + hikeValue;
        return ownSavings;
    }

}
