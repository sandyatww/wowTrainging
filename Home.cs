using System;


public interface IHome
{
  // declaration
  string CustomerName();
  void PrintDetails();

}

public class Home : IHome {
  public string CustomerName()
  {
    throw new NotImplementedException();
  }

  // implementation or defining


  public void PrintDetails(int a, string b)
  {
    Console.WriteLine("Name : " + a + " " + b);
  }

  public void PrintDetails()
  {
    throw new NotImplementedException();
  }

  internal void PrintDetails(User u)
  {
    Console.WriteLine("class print : " + u);
    Console.WriteLine("Location : " + u.Location + " " + u.Name);
  }

  internal void PrintDetails(string v)
  {
   Console.WriteLine("Name : " + v + " ");
  }
}

