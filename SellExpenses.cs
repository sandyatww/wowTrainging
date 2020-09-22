using System;
using tes;
public class SellExpense
{
    public double sellProfit;
    public double salePriceNow { get; set; }
    public double salesCostPercent { get; set; }
    public double pendingMortgage { get; set; }

    public SellExpense(double salePriceNow, double salesCostPercent, double pendingMortgage)
    {
        this.salePriceNow = salePriceNow;
        this.salesCostPercent = salesCostPercent;
        this.pendingMortgage = pendingMortgage;
    }
    public double MoneyLeftAfterSale()
    {
        double salesCost = salePriceNow * salesCostPercent;
        return salePriceNow - (salesCost + pendingMortgage);
    }

}

