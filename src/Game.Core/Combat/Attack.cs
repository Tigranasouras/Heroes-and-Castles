namespace Game.Core.Combat;

public class Attack
{
    public double Damage {get;}

    public Attack(double damage)
    {
        Damage = damage;
    }

    public void DoDamage(IDamageable target)
    {
        if (!target.IsAlive)
        {
            return;
        }
        target.TakeDamage(Damage);
    }
    
}