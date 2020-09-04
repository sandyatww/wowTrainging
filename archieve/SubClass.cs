using System;
class SubClass
{
     AddClass addobj = new AddClass();
  public int c, d; 
  public int tempValue { get; set; }

  public SubClass()
  {
      Console.WriteLine("Substraction class constructor has been called");
  }
 

  public int Subtract()
  {

    c = addobj.Addition(5, 5);
    d = (c - ((c * 10) / 100));
    return d;
  }

}