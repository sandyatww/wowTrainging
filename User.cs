class User

{
  private string location;
  private string name = "Suresh Dasari";
  public string Location
  {
    get { return location; }
    set { location = value; }
  }

  public string Name
  {
    get
    {
      return name.ToUpper();
    }
    set
    {
      if (value == "Suresh")
        name = value;
    }

  }

}