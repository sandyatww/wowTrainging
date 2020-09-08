using System;

namespace wowTrainging
{
  class Program
  {
    static void Main(string[] args)
    {
      User u = new User();

      // set accessor will invoke

      u.Name = "Rohini";

      // set accessor will invoke

      u.Location = "Hyderabad";

      // get accessor will invoke

      Console.WriteLine("Name: " + u.Name);

      // get accessor will invoke

      Console.WriteLine("Location: " + u.Location);

      Console.WriteLine("\nPress Enter Key to Exit..");
    }
  }
}
