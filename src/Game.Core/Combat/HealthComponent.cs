namespace Game.Core.Combat;

public class HealthComponent
{

    public double CurrentHealth {get; private set;}


    public HealthComponent(double health)
    {
        CurrentHealth = health;
    }

    public bool IsAlive => CurrentHealth > 0 ;

    public void TakeDamage(double damage)
    {
        if (damage <= 0)
        {
            return;
        }
        CurrentHealth = Math.Max(0, CurrentHealth - amount);
        Console.WriteLine("I've been attacked!");
    }
    
}