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
                    Name = "Black",
                    Dices = new List<Dices>
                    {
                        new Dices { Value = 6, Output = "6" },
                        new Dices { Value = 6, Output = "6" },
                        new Dices { Value = 6, Output = "6" },
                        new Dices { Value = 6, Output = "6" }
                    }
                },
                new Player
                {
                    Name = "White",
                    Dices = new List<Dices>
                    {
                        new Dices { Value = 3, Output = "3" },
                        new Dices { Value = 3, Output = "3" },
                        new Dices { Value = 3, Output = "3" },
                        new Dices { Value = 3, Output = "3" }
                    }
                }
            };
            actual.Should().BeEquivalentTo(expected);

        }
    }
}
