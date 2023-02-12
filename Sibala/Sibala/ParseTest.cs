using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Sibala
{
    [TestFixture]
    public class ParseTest
    {
        [Test]
        public void A01_ParsePlayerInfo()
        {
            var parse = new Parse();
            var actual = parse.Parser("Black: 6 6 6 6  White: 3 3 3 3");
            var expected = new List<Player>
            {
                new Player
                {
                    Name = "Black",
                    Dices = new List<Dice>
                    {
                        new Dice{ Value = 6 },
                        new Dice{ Value = 6 },
                        new Dice{ Value = 6 },
                        new Dice{ Value = 6 }
                    }
                },
                new Player
                {
                    Name = "White",
                    Dices = new List<Dice>
                    {
                        new Dice{ Value = 3 },
                        new Dice{ Value = 3 },
                        new Dice{ Value = 3 },
                        new Dice{ Value = 3 }
                    }
                }
            };
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
