namespace Game.Core.Combat;

public class Brute : Monster
{
    public string BruteName = "Brute";
    public double attack = 50;
    public Attack EventAttack;

    public Brute(int health) : base(health)
    {
        BruteName = "Brute";
        EventAttack = new Attack(); // Initialize the attack
    }

    public void Attacking(Monster target)
    {
        EventAttack.DoDamage(attack, target);
    }

  

    
}