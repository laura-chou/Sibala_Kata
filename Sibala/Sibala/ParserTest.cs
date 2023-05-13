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
