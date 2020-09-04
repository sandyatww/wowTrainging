using System;
using Training;

namespace Training
{
   public class Subtract
    {
        public double sum;
        Add ad = new Add();

        public double calculation()
            {
               //Add ad = new Add();
               sum = ad.AddTwoNumbers(25, 15); 
               Console.WriteLine("The sum of two numbers is"+" "+sum);
               double result=(sum-((sum*10)/100));
               return result;
            }

    }  

}