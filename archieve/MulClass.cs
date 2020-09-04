using System;
class MulClass
{

SubClass subobj = new SubClass();
    
   public int e = 10;
//SubClass subobj = new SubClass();

public int Multiplication()
 {
     e = subobj.Subtract();
    int MulResult = (e*150) / 100 ;
    return MulResult;
 }

 public void PrintAnswer()
 {
     
     Console.WriteLine("The value is: " + Multiplication());
 }

}