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


    public double getRentIncome()
    {
        double agencyFees = yearlyRent * rentAgencyRate;
        double income = (yearlyRent - agencyFees) * numberOfYears;
        return income;
    }

    public double getPropertyHike()
    {
        double currentPropertyValue = 1;
        if (numberOfYears > 0)
        {
            double body = 1 + (hikePercent / 12);
            double exponent = 12 * numberOfYears;
            double power = Math.Pow(body, exponent);
            currentPropertyValue = salePriceNow + (salePriceNow * power);
            Console.WriteLine("The current property value is" + " " + currentPropertyValue);

        }
        else
        {
            Console.WriteLine("The current property value is" + " " + salePriceNow);
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
