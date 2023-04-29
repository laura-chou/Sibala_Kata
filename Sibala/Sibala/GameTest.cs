using FluentAssertions;
using NUnit.Framework;
using Sibala.src;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        [TestCase("Black: 2 5 3 3  White: 2 2 1 3", "Black win. - with normal point: 7")]
        public void A01_BothNormalPoint(string input, string expected)
        {
            var game = new Game();
            var actual = game.ShowResult(input);
            actual.Should().Be(expected);
        }
    }
}
