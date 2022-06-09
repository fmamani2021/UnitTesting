using Xunit;

namespace GameEngine.Test
{
    public class PlayerCharacterShould_BooleanAssert
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }
    }
}
