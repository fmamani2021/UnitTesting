using Xunit;

namespace GameEngine.Test.ExternalData
{
    public class NonPlayerCharacterShould
    {
        [Theory]
        [MemberData(nameof(ExternalHealthDamageTestData.TestData), 
            MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamage(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }
    }
}
