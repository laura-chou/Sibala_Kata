using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;

namespace Sibala
{
    public class ParseTest
    {
        [Test]
        public void A01_Parser()
        {
            var parse = new Parse();
            var actual = parse.Parser("Black: 6 6 6 6  White: 3 3 3 3");
            var expected = new List<Player>
            {
                new Player
                {
                    Name = "Black"
                },
                new Player
                {
                    Name = "White"
                }
            };
            actual.Should().BeEquivalentTo(expected);

        }
    }
}
