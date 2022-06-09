using System;
using Xunit;

namespace GameEngine.Test
{
    public class EnemyFactoryShould_ExceptionAsserts
    {
        [Fact]
        public void NotAllowNullName()
        {
            EnemyFactory sut = new EnemyFactory();

            // Assert.Throws<ArgumentNullException>(() => sut.Create(null));
            Assert.Throws<ArgumentNullException>("name", () => sut.Create(null));
        }

        [Fact]
        public void OnlyAllowKingOrQueenBossEnemies()
        {
            EnemyFactory sut = new EnemyFactory();

            EnemyCreationException ex =
                Assert.Throws<EnemyCreationException>(() => sut.Create("Zombie", true));

            Assert.Equal("Zombie", ex.RequestedEnemyName);
        }
    }
}
