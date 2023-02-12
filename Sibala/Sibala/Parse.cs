using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class Parse
    {
        public List<Player> Parser(string input)
        {
            var player1Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Name = player1Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Dices = player1Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => new Dice{ Value = int.Parse(s) })
                .ToList();

            return new List<Player>
            {
                new Player
                {
                    Name = player1Name,
                    Dices = new List<Dice>(player1Dices)
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
        }
    }
}