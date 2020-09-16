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
    public double getMaintenanceCost()
    {
        double maintenanceTotal=0;
        if (numberOfYears > 0)
        {
            maintenanceTotal = (propMaintenance + waterRates + councilTax + insurance + mortgageInterest) * numberOfYears;
            Console.WriteLine("The maintance cost for" + " " + numberOfYears + "is" + maintenanceTotal);
        }
        else
        {
            Console.WriteLine("The maintenance cost is" +" "+ maintenanceTotal);
        }
        return maintenanceTotal;
    }

}
