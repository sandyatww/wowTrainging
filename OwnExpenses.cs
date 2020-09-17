using System;

using tes;
public class OwnExpenses
{
    public double propMaintenance { get; set; }
    public double waterRates { get; set; }
    public double councilTax { get; set; }

    public double insurance { get; set; }

    public double mortgageInterest { get; set; }
    public double numberOfYears { get; set; }

    SellInvestment sellinvest;


// three way to access class member from other class. 1 is via Object, 2. via inheritence , 3 is declaring the class memeber as static
    
    public OwnExpenses(SellInvestment invest)
    {
        sellinvest = invest;
    }
    public double getMaintenanceCost()
    {
        double maintenanceTotal = 0;
        if (sellinvest.numberOfYears > 0)
        {
            maintenanceTotal = (propMaintenance + waterRates + councilTax + insurance + mortgageInterest) * sellinvest.numberOfYears;
            Console.WriteLine("The maintenance cost for" + " " + sellinvest.numberOfYears + " "+"years is" +" " + maintenanceTotal);
        }
        else
        {
            Console.WriteLine("The maintenance cost is" + " " + maintenanceTotal);
        }
        return maintenanceTotal;
    }

}
