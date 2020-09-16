using System;
using tes;
public class SellExpense
{
    //public double sellProfit;
    public double salePriceNow { get; set; }
    public double salesCostPercent { get; set; }
    public double pendingMortgage { get; set; }
    public double getExpense()
    {
        double salesCost = salePriceNow * salesCostPercent;
        double sellProfit = salePriceNow - (salesCost + pendingMortgage);
        Console.WriteLine("Sell profit or investment money is"+ " "+sellProfit);
        return sellProfit;
    }


}

