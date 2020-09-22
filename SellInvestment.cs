using System;
using System.Collections.Generic;
using tes;

public class SellInvestment
{
    public double roiPercentage { get; set; }
    public int numberOfYears { get; set; }

    //public double moneyInvested{get;set;}
    public double MoneyLeftAfterSale{get;set;}

    //public int numberOfYear =60;
    //public double expense{get;set;}
  SellExpense exp1; // variable type is class here rather then string or int. 

  public SellInvestment(SellExpense sellexp, double MoneyLeftAfterSale,double roiPercentage,int numberOfYears)
  {
    this.exp1=sellexp;
    this.MoneyLeftAfterSale = MoneyLeftAfterSale;
    this.roiPercentage=roiPercentage;
    this.numberOfYears=numberOfYears;
  }

  public double getInvestmentPlan()
    {
       
        double compoundedValue=0;
        if (this.numberOfYears > 0)
        {
            double body = (1 + (roiPercentage / 12));
            double exponent = 12 * this.numberOfYears;
            double pow = Math.Pow(body, exponent);
            compoundedValue =  this.exp1.MoneyLeftAfterSale() * pow;
            Console.WriteLine("The compounded value is" + " " + compoundedValue);
        }
        else
        {
            compoundedValue=MoneyLeftAfterSale;
            Console.WriteLine("Since it was less than an year, no interest is added. The amount received will be " + " " + compoundedValue);
        }
        return compoundedValue;
    }


}


