using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sibala
{
    [TestFixture]
    public class ParseTest
    {
        [Test]
        public void A01_ParserInput()
        {
            var parse = new Parse();
            var actual = parse.Parser("Black: 2 5 3 3  White: 2 2 1 3");
            var expexted = new List<Player>
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
            actual.Should().BeEquivalentTo(expexted);
        }
    }
}
