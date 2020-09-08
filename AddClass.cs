using System;

class AddClass
{
    public AddClass()
    {
    }
public int GetoneNumber {get; set;}
public int GettwoNumber {get; set;}

public AddClass(int Num1, int Num2 )
{
 GetoneNumber = Num1;
 GettwoNumber = Num2;
}
    public void AddNumber()
    {
        
 Console.WriteLine("The added value is :" + (GetoneNumber + GettwoNumber)); 
 

   }
}