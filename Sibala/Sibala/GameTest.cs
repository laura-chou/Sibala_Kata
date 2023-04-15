using NUnit.Framework;
using FluentAssertions;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void A01_BothNormalPoint()
        {
            var game = new Game();
            var actual = game.ShowResult("Black: 2 5 3 3  White: 2 2 1 3");
            actual.Should().Be("Black win. - with normal point: 7");
        }
    }
}
