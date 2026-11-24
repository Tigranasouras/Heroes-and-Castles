namespace Game.Core.Combat;

public class Attack
{
    public double Damage {get;}

    public Attack(double damage)
    {
        Damage = damage;
    }

    public void DoDamage(Monster target)
    {
        if (!target.Health.IsAlive)
        {
            return;
        }
        target.Health.TakeDamage(Damage);
    }
    
}