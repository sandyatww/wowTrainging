using System;

using tes;
public class OwnExpenses
{
    public double propMaintanance { get; set; }
    public double waterRates { get; set; }
    public double councilTax { get; set; }

    public double insurance { get; set; }

    public double mortgageInterest { get; set; }
    public double numberOfYears { get; set; }
    public double getMaintananceCost()
    {
        double maintainanceTotal = 0;
        if (numberOfYears > 0)
        {
            maintainanceTotal = (propMaintanance + waterRates + councilTax + insurance + mortgageInterest) * numberOfYears;
            Console.WriteLine("The maintance cost for" + " " + numberOfYears + "is" + maintainanceTotal);
        }
        else
        {
            Console.WriteLine("The maintance cost is" +" "+ maintainanceTotal);
        }
        return maintainanceTotal;
    }

}
