using System;

class Selling
{
    public double SalePriceNow { get; set; }
    public double SalesCostPercentage { get; set; }
    public double PendingMortgage { get; set; }
    public double ROI { get; set; }


  /*  public int Year;

    public Selling(int year)
    {
        Year = year;
    }
    */

   /* public double GetSalesCost(double SalePriceNow, double SalesCostPercentage)
    {

        double salescost = ((SalePriceNow * SalesCostPercentage) / 100);
        //Console.WriteLine("Sales Cost is : " + salescost);
        return salescost;
    }*/

    public double GetMoneyLeft(double SalePriceNow, double PendingMortgage, double SalesCostPercentage)
    {
        double moneyleft = (SalePriceNow) - ((SalePriceNow * SalesCostPercentage) / 100) - (PendingMortgage);
        //Console.WriteLine("Money Left is : " + moneyleft);
        return moneyleft;

    }


    public double GetMoneyGainedOnSelling(double ROI, int Year)
    {
        double moneygainedonselling = (GetMoneyLeft) * (ROI) * (Year);
        return moneygainedonselling;
    }


}
