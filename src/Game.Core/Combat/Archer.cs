namespace Game.Core.Combat;

public class Archer : Monster
{
    public string ArcherName = "Archer";

    public Archer(int health) : base(health, new Attack(25))
    {
        ArcherName = "Archer";
    }



    
}
