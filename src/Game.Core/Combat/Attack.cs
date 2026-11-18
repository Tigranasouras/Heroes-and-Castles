namespace Game.Core.Combat;

public class Attack
{

    public void DoDamage(Monster target, double damage)
    {
        target.Health.TakeDamage(damage);
    }
    
}