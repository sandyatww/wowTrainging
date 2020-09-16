using System;
using System.Collections.Generic;
using tes;

public class SellInvestment
{
    public double roiPercentage { get; set; }
    public int numberOfYears { get; set; }

    public double moneyInvested { get; set; }
    //public int numberOfYear =60;

    //public double expense{get;set;}
    //SellExpense exp = new SellExpense();
    public double getInvestmentPlan()
    {
        if (numberOfYears > 0)
        {
            double compoundedValue=1;
            for (int i = 1; i <= numberOfYears; i++)
            {
                double body = 1+(roiPercentage/12);
                double exponent = 12 * numberOfYears;
                double pow = Math.Pow(body, exponent);
                compoundedValue = moneyInvested * pow;
            }

            Console.WriteLine("The compounded value is" + ":" + compoundedValue);
            return compoundedValue;
        }
        else
        {
            return moneyInvested;
        }
    }


}

