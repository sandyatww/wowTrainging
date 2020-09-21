using System;
class Decision
{

      Selling s = new Selling(1);
      s.GetMoneyLeft(720000,560500,3);
      s.GetMoneyGainedOnSelling(s.GetMoneyLeft(720000,560500,3),12);
      Console.WriteLine("The money gained on Selling the property in 1 year is " + s.moneygainedonselling);

            Selling s1 = new Selling(3);
            s1.GetMoneyLeft(720000,560500,3);
            s1.GetMoneyGainedOnSelling(s1.GetMoneyLeft(720000,560500,3),12);
            Console.WriteLine("The money gained on Selling the property in 3 years is " + s1.moneygainedonselling);

            Selling s2 = new Selling(5);
            s2.GetMoneyLeft(720000,560500,3);
            s2.GetMoneyGainedOnSelling(s2.GetMoneyLeft(720000,560500,3),12);
            Console.WriteLine("The money gained on Selling the property in 5 years is " + s2.moneygainedonselling);
            double sellingbenefit = s2.moneygainedonselling;

            Owning o = new Owning();
            o.LessSaleCost(720000,4,3);
            o.MoneyGainedOnOwning(33319.2,720000,4,560500,1);
            Console.WriteLine("The money gained on Owning the property in 1 year is " + o.moneygainedonowning);

             Owning o1 = new Owning();
            o1.LessSaleCost(720000,4,3);
            o1.MoneyGainedOnOwning(33319.2,720000,4,560500,3);
            Console.WriteLine("The money gained on Owning the property in 3 years is " + o1.moneygainedonowning);

            Owning o2 = new Owning();
            o2.LessSaleCost(720000,4,3);
            o2.MoneyGainedOnOwning(33319.2,720000,4,560500,5);
            Console.WriteLine("The money gained on Owning the property in 5 years is " + o2.moneygainedonowning);
            double owningbenefit = o2.moneygainedonowning;
}
}