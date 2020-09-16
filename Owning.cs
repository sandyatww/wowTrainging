using System;
class Owning
{
    public double yearlyloss { get; set; }
    public double SalePriceNow { get; set; }
    public double propertyhike { get; set; }

    public double lessmortage { get; set; }


    public int Years;
    public Owning(int years)
    {
        Years = years;
    }

    public double SalesCostPercentage { get; set; }

    public double GetAnnualHike()
    {

        double annualhike = ((SalePriceNow) * (propertyhike / 100));
       // Console.WriteLine("Annual Hike is : " + annualhike);
        return annualhike;
    }


    public double ExpectedSalesValue()
    {
        double expectedsalesvalue = (SalePriceNow + GetAnnualHike());
        //Console.WriteLine("Expected Sales Value is : " + expectedsalesvalue);
        return expectedsalesvalue;
    }

    public double LessSaleCost()
    {
        double lesssalecost = (ExpectedSalesValue() * ((SalesCostPercentage) / 100));
        //Console.WriteLine("Less Sale Cost Value is : " + lesssalecost);
        return lesssalecost;
    }

    public double MoneyGainedOnOwning()
    {
        double moneygainedonowning = (((yearlyloss) + (ExpectedSalesValue()) + (LessSaleCost()) - (lessmortage)) * (Years));
        //Console.WriteLine("Money Gained On Selling is : " + moneygainedonowning);
        return moneygainedonowning;

    }

}
