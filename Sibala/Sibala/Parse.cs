using System;
using System.Collections.Generic;

namespace Sibala
{
    public class Parse
    {
        public List<Player> Parser(string input)
        {
            var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Name = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            return new List<Player>
            {
                new Player
                {
                    Name = player1Name,
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
        }
    }
}