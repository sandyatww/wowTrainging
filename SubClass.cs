using System;
class SubClass
{
    public int c,d; // creating an object

    public int Subtract()
 {
    AddClass addobj = new AddClass();
     c = addobj.Addition(5,5);
     d = (c - ((c*10)/100));
     return d;
 }

}