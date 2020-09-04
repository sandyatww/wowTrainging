using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculations calc = new Calculations(2000);

           Console.WriteLine(calc.PrintTotalBalance(4.5));
           
        }
}

}