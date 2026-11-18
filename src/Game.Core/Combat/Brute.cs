namespace Game.Core.Combat;

public class Brute : Monster
{
    public string BruteName = "Brute";

    public Brute(int health) : base(health, new Attack(50))
    {
        BruteName = "Brute";
    }



  

    
}