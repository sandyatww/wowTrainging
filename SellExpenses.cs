using System;
using tes;
public class SellExpense
{
    //public double sellProfit;
   // public double salePriceNow { get; set; }
   // public double salesCostPercent { get; set; }
    //public double pendingMortgage { get; set; }
   public double MoneyLeftAfterSale(double salePriceNow, double salesCostPercent, double pendingMortgage)
  {
    double salesCost = salePriceNow * salesCostPercent;
    return salePriceNow - (salesCost + pendingMortgage);
  }

 

  


}

