namespace Game.Core.Combat;

public class Archer : Monster
{
    public string ArcherName = "Archer";
    public double attack = 25;
    public Attack EventAttack;

    public Archer(int health) : base(health)
    {
        ArcherName = "Archer";
        EventAttack = new Attack();
    }

    public void Attacking(Monster target)
    {
        EventAttack.DoDamage(attack, target);
    }


    
}
