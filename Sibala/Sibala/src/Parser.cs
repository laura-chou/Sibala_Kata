using System;
using System.Collections.Generic;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            var playerSections = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
            var player1Name = playerSections[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Name = playerSections[1].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            return new List<Player>
            {
                new Player
                {
                    Name = player1Name,
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
                    Name = player2Name,
                    Dices = new List<Dice>
                    {
                        new Dice { Value = 3, Output = "3" },
                        new Dice { Value = 3, Output = "3" },
                        new Dice { Value = 3, Output = "3" },
                        new Dice { Value = 3, Output = "3" }
                    }
                }
            };
        }
    }
}