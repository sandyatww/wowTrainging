using System;
class MulClass
{

public int Multiplication()
 {
    SubClass subobj = new SubClass();
   int e = subobj.Subtract();
    int MulResult = (e*150) / 100 ;
     return MulResult;
 }

 public void PrintAnswer()
 {
     Console.WriteLine("The value is: " + Multiplication());
 }

}