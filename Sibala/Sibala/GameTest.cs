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
            ResultShouldReturn("Black: 6 6 6 6  White: 3 3 3 3", "Black win. - with all of a kind: 6");
        }

        private void ResultShouldReturn(string input, string expected)
        {
            var actual = _game.ShowResult(input);
            actual.Should().Be(expected);
        }
    }
}
