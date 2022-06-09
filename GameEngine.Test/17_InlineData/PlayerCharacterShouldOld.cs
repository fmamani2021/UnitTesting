using System;
using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Test.InlineData
{
    public class PlayerCharacterShouldOld : IDisposable
    {
        private readonly PlayerCharacter _sut;
        private readonly ITestOutputHelper _output;

        public PlayerCharacterShouldOld(ITestOutputHelper output)
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


        [Fact]
        public void TakeZeroDamage()
        {
            _sut.TakeDamage(0);

            Assert.Equal(100, _sut.Health);
        }

        [Fact]
        public void TakeSmallDamage()
        {
            _sut.TakeDamage(1);

            Assert.Equal(99, _sut.Health);
        }

        [Fact]
        public void TakeMediumDamage()
        {
            _sut.TakeDamage(50);

            Assert.Equal(50, _sut.Health);
        }

        [Fact]
        public void HaveMinimum1Health()
        {
            _sut.TakeDamage(101);

            Assert.Equal(1, _sut.Health);
        }

    }
}
