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
            var actual = parser.Parse("Black: 6 6 6 6  White: 3 3 3 3");
            var expected = new List<Player>
            {
                new Player
                { 
                    Name = "Black",
                    Dices = new List<Dice>
                    {
                        new Dice { Value = 6, Output = "6" },
                        new Dice { Value = 6, Output = "6" },
                        new Dice { Value = 6, Output = "6" },
                        new Dice { Value = 6, Output = "6" }
                    }
                },
                new Player
                {
                    Name = "White",
                    Dices = new List<Dice>
                    {
                        new Dice { Value = 3, Output = "3" },
                        new Dice { Value = 3, Output = "3" },
                        new Dice { Value = 3, Output = "3" },
                        new Dice { Value = 3, Output = "3" }
                    }
                }
            };
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
