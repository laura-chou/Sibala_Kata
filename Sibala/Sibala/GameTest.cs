using FluentAssertions;
using NUnit.Framework;
using Sibala.src;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        [TestCase("Black: 6 6 6 6  White: 3 3 3 3", "Black win. - with all of a kind: 6")]
        [TestCase("Black: 2 2 2 2  White: 5 5 5 5", "White win. - with all of a kind: 5")]
        [TestCase("Black: 2 2 2 2  White: 2 2 2 2", "Tie")]
        [TestCase("Black: 4 4 4 4  White: 6 6 6 6", "Black win. - with all of a kind: 4")]
        [TestCase("Black: 6 6 6 6  White: 4 4 4 4", "White win. - with all of a kind: 4")]
        [TestCase("Black: 1 1 1 1  White: 4 4 4 4", "Black win. - with all of a kind: 1")]
        [TestCase("Black: 4 4 4 4  White: 1 1 1 1", "White win. - with all of a kind: 1")]
        public void A01_BothAllOfKind(string input, string expected)
        {
            AssertResultShouldReturn(input, expected);
        }
        
        [TestCase("Black: 2 5 3 3  White: 2 2 1 3", "Black win. - with normal point: 7")]
        [TestCase("Black: 5 3 5 4  White: 2 6 2 3", "White win. - with normal point: 9")]
        [TestCase("Black: 2 3 4 2  White: 1 1 4 3", "Tie")]
        [TestCase("Black: 5 5 1 1  White: 1 2 1 4", "Black win. - with normal point: 10")]
        [TestCase("Black: 3 4 5 5  White: 4 1 4 6", "White win. - with normal point: 7")]
        public void A02_BothNormalPoint(string input, string expected)
        {
            AssertResultShouldReturn(input, expected);
        }
        
        [TestCase("Black: 6 6 6 6  White: 3 1 3 5", "Black win. - with all of a kind: 6")]
        public void A03_DifferentCategory(string input, string expected)
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
