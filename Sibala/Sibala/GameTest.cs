using NUnit.Framework;
using FluentAssertions;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        [TestCase("Black: 2 5 3 3  White: 2 2 1 3", "Black win. - with normal point: 7")]
        [TestCase("Black: 5 3 5 4  White: 2 6 2 3", "White win. - with normal point: 9")]
        [TestCase("Black: 2 3 4 2  White: 1 1 4 3", "Tie")]
        [TestCase("Black: 5 5 1 1  White: 1 2 1 4", "Black win. - with normal point: 10")]
        public void A01_BothNormalPoint(string input, string expected)
        {
            var game = new Game();
            var actual = game.ShowResult(input);
            actual.Should().Be(expected);
        }
    }
}
