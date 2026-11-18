using Game.Core.Combat;

namespace Game.Tests;

public class CombatTests
{
    [Fact]
    public void Brute_Attack_ReducesTargetHealth()
    {
        // Arrange
        Brute brute = new Brute(200);
        Archer archer = new Archer(100);

        // Act
        brute.Attacking(archer);

        // Assert
        Assert.Equal(50.0, archer.Health.CurrentHealth);
    }
}