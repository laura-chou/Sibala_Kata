using FluentAssertions;
using NUnit.Framework;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void A01_BothAllOfKind()
        {
            var game = new Game();
            var actual = game.ShowResult("Black: 6 6 6 6  White: 3 3 3 3");
            actual.Should().Be("Black win. - with all of a kind: 6");
        }
    }
}
