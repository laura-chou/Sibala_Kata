using FluentAssertions;
using NUnit.Framework;
using Sibala.src;
using System.Collections.Generic;

namespace Sibala
{
    public class ParserTest
    {
        [Test]
        public void A01_ParseInput()
        {
            var parser = new Parser();
            var actual = parser.Parse("Black: 6 6 6 6  White: 3 3 3 3");
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
