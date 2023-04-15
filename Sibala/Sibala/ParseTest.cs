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
                    Name = "Black",
                    Dices = new List<Dices>
                    {
                        new Dices {Value = 2, Output = "2"},
                        new Dices {Value = 5, Output = "5"},
                        new Dices {Value = 3, Output = "3"},
                        new Dices {Value = 3, Output = "3"}
                    }
                },
                new Player
                {
                    Name = "White",
                    Dices = new List<Dices>
                    {
                        new Dices {Value = 2, Output = "2"},
                        new Dices {Value = 2, Output = "2"},
                        new Dices {Value = 1, Output = "1"},
                        new Dices {Value = 3, Output = "3"}
                    }
                }
            };
            actual.Should().BeEquivalentTo(expexted);
        }
    }
}
