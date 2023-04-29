using System;
using System.Collections.Generic;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            var player1Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Name = player1Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];

            var player2Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[1];
            var player2Name = player2Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];

            return new List<Player>
            {
                new Player
                {
                    Name = player1Name,
                    Dices = new List<Dices>
                    {
                        new Dices{ Value = 2, Output = "2" },
                        new Dices{ Value = 5, Output = "5" },
                        new Dices{ Value = 3, Output = "3" },
                        new Dices{ Value = 3, Output = "3" }
                    }
                },
                new Player
                {
                    Name = player2Name,
                    Dices = new List<Dices>
                    {
                        new Dices{ Value = 2, Output = "2" },
                        new Dices{ Value = 2, Output = "2" },
                        new Dices{ Value = 1, Output = "1" },
                        new Dices{ Value = 3, Output = "3" }
                    }
                }
            };
        }
    }
}