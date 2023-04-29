using FluentAssertions;
using NUnit.Framework;
using Sibala.src;
using System.Collections.Generic;

namespace Sibala
{
    [TestFixture]
    public class ParserTest
    {
        [Test]
        public void A01_Parse()
        {
            var parser = new Parser();
            var actual = parser.Parse("Black: 2 5 3 3  White: 2 2 1 3");
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
