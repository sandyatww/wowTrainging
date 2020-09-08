using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
           //Calculations calc = new Calculations(2000);

           //Console.WriteLine(calc.PrintTotalBalance(4.5));

           AddClass add = new AddClass(1,5);
            add.AddNumber();
           AddClass add1 = new AddClass(2,10);
            add1.AddNumber();
        }
}

}