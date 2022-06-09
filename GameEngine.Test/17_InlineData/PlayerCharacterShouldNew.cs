using System;
using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Test.InlineData
{
    public class PlayerCharacterShouldNew : IDisposable
    {
        private readonly PlayerCharacter _sut;
        private readonly ITestOutputHelper _output;

        public PlayerCharacterShouldNew(ITestOutputHelper output)
        {
            _output = output;

            _output.WriteLine("Creating new PlayerCharacter");
            _sut = new PlayerCharacter();
        }

        public void Dispose()
        {
            _output.WriteLine($"Disposing PlayerCharacter {_sut.FullName}");

            //_sut.Dispose();
        }


        [Theory]
        [InlineData(0, 100)]
        [InlineData(1, 99)]
        [InlineData(50, 50)]
        [InlineData(101, 1)]
        public void TakeDamage(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, _sut.Health);
        }
    }
}
