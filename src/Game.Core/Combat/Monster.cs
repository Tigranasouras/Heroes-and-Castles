namespace Game.Core.Combat;

public class Monster
{
    public HealthComponent Health {get;}


    public Monster(double startHealth){ //pass into constructor
        Health = new HealthComponent(startHealth);
    } 
    
}