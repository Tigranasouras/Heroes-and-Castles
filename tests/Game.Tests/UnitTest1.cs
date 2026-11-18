using Game.Core.Combat;

namespace Game.Tests;

public class HealthComponentTests
{
    [Fact]
    public void TakingDamage_ReducesHealth()
    {
        // Arrange
        HealthComponent health = new HealthComponent(100);

        // Act
        health.TakeDamage(25);

        // Assert
        Assert.Equal(75, health.CurrentHealth);
    }
}