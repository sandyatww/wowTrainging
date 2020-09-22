using System;

using tes;
public class OwnExpenses
{
    //public double propMaintenance { get; set; }
   //public double waterRates { get; set; }
   // public double councilTax { get; set; }

    //public double insurance { get; set; }

   //public double mortgageInterest { get; set; }
   //public double numberOfYears { get; set; }

   // SellInvestment sellinvest;
   public SellInvestment invest{get;set;}


// three way to access class member from other class. 1 is via Object, 2. via inheritence , 3 is declaring the class memeber as static
    
    public OwnExpenses(SellInvestment invest)
    {
        this.invest = invest;
    }
    public double getMaintenanceCost(double propMaintenance,double waterRates,double councilTax, double insurance, double mortgageInterest)
    {
        double maintenanceTotal = 0;
        if (this.invest.numberOfYears > 0)
        {
            maintenanceTotal = (propMaintenance + waterRates + councilTax + insurance + mortgageInterest) * this.invest.numberOfYears;
            Console.WriteLine("The maintenance cost for" + " " + this.invest.numberOfYears + " "+"years is" +" " + maintenanceTotal);
        }
        else
        {
            Console.WriteLine("The maintenance cost is" + " " + maintenanceTotal);
        }
        return maintenanceTotal;
    }

}
