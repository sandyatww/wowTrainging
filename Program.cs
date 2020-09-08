using System;

namespace wowTrainging
{
  class Program
  {
    static void Main(string[] args)
    {
      User u = new User();
      Home h = new Home();

      u.Location = "Strathfield";
      u.Name = "Reshmi";
      h.PrintDetails(u);

      u.Location = "Burwood";
      h.PrintDetails(u.Location);
    }
  }
}
