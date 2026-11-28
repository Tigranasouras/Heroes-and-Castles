namespace Game.Core.Combat;

public class Monster : IDamageable
{
    public HealthComponent Health {get;}

    public Attack EventAttack { get;}

    public Monster(double startHealth, Attack attack){ //pass into constructor
        EventAttack = attack;
    } 

    public void Attacking(IDamageable target, double Damage)
    {
        EventAttack.DoDamage(target.TakeDamage(Damage));
    }

    
    
}