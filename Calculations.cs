public class Calculations
{

public double PrincipleAmount { get; set; }

public Calculations(double amt)
{
    this.PrincipleAmount = amt;
}

public double PrintTotalBalance(double roi){
  return PrincipleAmount*roi/100;
}


}