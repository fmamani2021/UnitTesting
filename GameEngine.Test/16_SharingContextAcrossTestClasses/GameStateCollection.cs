using Xunit;

namespace GameEngine.Test.SharingContextAcrossTestClasses
{
    [CollectionDefinition("GameState collection")]
    public class GameStateCollection : ICollectionFixture<GameStateFixture> {}
}
