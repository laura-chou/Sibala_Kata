using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Sibala
{
    [TestFixture]
    public class ParseTest
    {
        [Test]
        public void A01_ParseInput()
        {
            var parse = new Parse();
            var actual = parse.Parser("Black: 6 6 6 6  White: 3 3 3 3");
            var expected = new List<Player>
            {
                new Player
                {
                    Name = "Black",
                },
                new Player
                {
                    Name = "White",
                }
            };
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
