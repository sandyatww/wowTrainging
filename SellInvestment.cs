using System;
using System.Collections.Generic;
using tes;

public class SellInvestment
{
    public double roiPercentage { get; set; }
    public int numberOfYears { get; set; }

    public double moneyInvested{get;set;}

    //public int numberOfYear =60;

    //public double expense{get;set;}
    SellExpense exp = new SellExpense();
    public double getInvestmentPlan()
    {
        double compoundedValue=0;
        if (numberOfYears > 0)
        {
            double body = (1 + (roiPercentage / 12));
            double exponent = 12 * numberOfYears;
            double pow = Math.Pow(body, exponent);
            compoundedValue =  (exp.getExpense() * pow);
            Console.WriteLine("The compounded value is" + " " + compoundedValue);
        }
        else
        {
            compoundedValue=moneyInvested;
            Console.WriteLine("Since it was less than an year, no interest is added. The amount received will be " + " " + compoundedValue);
        }
        return compoundedValue;
    }


}
