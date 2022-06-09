using Xunit;

namespace GameEngine.Test
{
    public class PlayerCharacterShould_NullAsserts
    {
        [Fact]
        public void NotHaveNickNameByDefault()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.Null(sut.Nickname);
        }
    }
}
