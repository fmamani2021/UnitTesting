using System;
using Xunit;

namespace GameEngine.Test
{
    public class PlayerCharacterShould_EventAsserts
    {
        [Fact]
        public void RaiseSleptEvent()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.Raises<EventArgs>(
                handler => sut.PlayerSlept += handler,
                handler => sut.PlayerSlept -= handler,
                () => sut.Sleep());
        }


        [Fact]
        public void RaisePropertyChangedEvent()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.PropertyChanged(sut, "Health", () => sut.TakeDamage(10));
        }
    }
}
