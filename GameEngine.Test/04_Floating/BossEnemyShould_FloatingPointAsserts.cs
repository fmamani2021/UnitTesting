using Xunit;

namespace GameEngine.Test
{
    public class BossEnemyShould_FloatingPointAsserts
    {
        [Fact]
        public void HaveCorrectPower()
        {
            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.SpecialAttackPower, 3);
        }
    }
}
