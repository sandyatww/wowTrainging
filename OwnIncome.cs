using System;
using tes;
public class OwnIncome
{
    double salePriceNow{get;set;}
    public SellInvestment sellinvest{get;set;}
    public SellExpense sellexp1{get;set;}
    public OwnIncome(SellInvestment invest, SellExpense sellexp)
    {
        this.sellinvest = invest;
        this.sellexp1 = sellexp;
    }
    public double getRentIncome(double yearlyRent, double rentAgencyRate)
    {
        double agencyFees = yearlyRent * rentAgencyRate;
        double income = (yearlyRent - agencyFees) * sellinvest.numberOfYears;
        return income;
    }
    public double getPropertyHike(double hikePercent)
    {
        double currentPropertyValue = 0;
        if (this.sellinvest.numberOfYears > 0)
        {
            double body = 1 + (hikePercent / 12);
            double exponent = 12 * sellinvest.numberOfYears;
            double power = Math.Pow(body, exponent);
            currentPropertyValue = this.sellexp1.salePriceNow + (this.sellexp1.salePriceNow)* power;
            Console.WriteLine("The current property value is" + " " + currentPropertyValue);
        }
        else
        {
            Console.WriteLine("The current property value is" + " " + this.sellexp1.salePriceNow);
        }
        return currentPropertyValue;
    }
    public double getOwnSavings(double yearlyRent, double rentAgencyRate,double hikePercent)
    {

        double rentValue = this.getRentIncome(yearlyRent, rentAgencyRate);
        double hikeValue = getPropertyHike(hikePercent);
        double ownSavings = rentValue + hikeValue;
        return ownSavings;
    }

}
