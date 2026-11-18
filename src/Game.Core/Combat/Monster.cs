namespace Game.Core.Combat;

public class Monster
{
    public HealthComponent Health {get;}

    public Attack EventAttack;
    public double Attack;



    public Monster(double startHealth, double Amount){ //pass into constructor
        Health = new HealthComponent(startHealth);
        Attack = Amount;
    } 

    public void Attacking(Monster target)
    {
        EventAttack.DoDamage(target, Attack);
    }
    
}