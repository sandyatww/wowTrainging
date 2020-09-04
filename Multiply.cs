using System;


namespace Training
{
   public class Multiply
    {
    public double minus;
        Subtract s=new Subtract();
       public double printValue()
        {
        //Subtract s=new Subtract();
        minus=s.calculation();
        Console.WriteLine("The value after subtracting 10% from the sum is"+" "+minus);
        double value=(minus*150)/100;
        return value;
        }

    }
}