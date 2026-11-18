namespace Game.Core.Combat;

public class Attack
{

    public void DoDamage(double damage, Monster target)
    {
        target.Health.TakeDamage(damage);
    }
    
}