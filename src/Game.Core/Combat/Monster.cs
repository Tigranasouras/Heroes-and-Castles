namespace Game.Core.Combat;

public class Monster
{
    public HealthComponent Health {get;}

    public Attack EventAttack { get;}

    public Monster(double startHealth, Attack attack){ //pass into constructor
        Health = new HealthComponent(startHealth);
        EventAttack = attack;
    } 

    public void Attacking(Monster target)
    {
        EventAttack.DoDamage(target);
    }
    
}