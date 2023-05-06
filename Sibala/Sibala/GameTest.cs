using FluentAssertions;
using NUnit.Framework;
using Sibala.src;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        [TestCase("Black: 2 5 3 3  White: 2 2 1 3", "Black win. - with normal point: 7")]
        [TestCase("Black: 5 3 5 4  White: 2 6 2 3", "White win. - with normal point: 9")]
        [TestCase("Black: 2 3 4 2  White: 1 1 4 3", "Tie")]
        [TestCase("Black: 5 5 1 1  White: 1 2 1 4", "Black win. - with normal point: 10")]
        [TestCase("Black: 3 4 5 5  White: 4 1 4 6", "White win. - with normal point: 7")]
        public void A01_BothNormalPoint(string input, string expected)
        {
            AssertResultShouldReturn(input, expected);
        }

        [Test]
        [TestCase("Black: 6 6 6 6  White: 3 3 3 3", "Black win. - with all of a kind: 6")]
        public void A02_BothAllOfKind(string input, string expected)
        {
            AssertResultShouldReturn(input, expected);
        }

        private void AssertResultShouldReturn(string input, string expected)
        {
            var actual = _game.ShowResult(input);
            actual.Should().Be(expected);
        }
    }
}
