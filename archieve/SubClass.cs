using System;
class SubClass
{
     AdditionClass addobj = new AdditionClass();
  public int c, d; 
  public int tempValue { get; set; }

  public SubClass()
  {
      Console.WriteLine("Substraction class constructor has been called");
  }
 

  public int Subtract()
  {

    c = addobj.Add(5, 5);
    d = (c - ((c * 10) / 100));
    return d;
  }

}