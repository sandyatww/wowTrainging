using System;

class Selling
{
    public double SalePriceNow { get; set; }
    public double SalesCostPercentage { get; set; }
    public double PendingMortgage { get; set; }
    public double ROI { get; set; }
    public double salescost;

    public int Year;

    public Selling(int year)
    {
        Year = year;
    }

    public double moneyleft;


    public double GetSalesCost()
    {

        double salescost = (SalePriceNow * SalesCostPercentage) / 100;
        Console.WriteLine("Sales Cost is : " + salescost);
        return salescost;


    }

    public double GetMoneyLeft()
    {
        double moneyleft = ((SalePriceNow) - (salescost) - (PendingMortgage));
        Console.WriteLine("Money Left is : " + moneyleft);

        return moneyleft;

    }

    public double GetMoneyGainedOnSelling()
    {
        double moneygainedonselling = moneyleft * ROI * Year;
        return moneygainedonselling;
    }


}
