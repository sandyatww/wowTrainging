using System;

namespace Training
{
   public class Program
    {
       public double total;
       public static void Main(string[] args)
        {
        //double finalValue=display();
        //Console.WriteLine("150% of the above value is"+" "+finalValue); 
        Console.WriteLine("150% of the above value is"+" "+display());
        Console.WriteLine("Reshmi");
        }
        public static double display()
        {
        Multiply m=new Multiply();
        double total=m.printValue();
        return total;
        }
    }
}


           