using FluentAssertions;
using NUnit.Framework;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void A01_BothAllOfKind()
        {
            var actual = _game.ShowResult("Black: 6 6 6 6  White: 3 3 3 3");
            actual.Should().Be("Black win. - with all of a kind: 6");
        }
    }
}
