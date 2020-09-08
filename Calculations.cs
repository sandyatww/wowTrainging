public class Calculations
{

public double PrincipleAmount { get; set; }

public Calculations(double amt)
{
    PrincipleAmount = amt;
}

public double PrintTotalBalance(double roi){
  return PrincipleAmount*roi/100;
}


}