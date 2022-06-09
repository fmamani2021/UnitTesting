using Xunit;

namespace GameEngine.Test
{
    public class EnemyFactoryShould_ObjectInstanceAsserts
    {
        [Fact]
        public void CreateSeparateInstances()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy1 = sut.Create("Zombie");
            Enemy enemy2 = sut.Create("Zombie");

            Assert.NotSame(enemy1, enemy2);
        }

    }
}
