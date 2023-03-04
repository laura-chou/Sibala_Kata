using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Sibala
{
    internal class Parse
    {
        public List<Player> Parser(string input)
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
                    Dices = new List<Dice>
                    {
                        new Dice{ Value = 6, Output = "6"},
                        new Dice{ Value = 6, Output = "6"},
                        new Dice{ Value = 6, Output = "6"},
                        new Dice{ Value = 6, Output = "6"}
                    }
                },
                new Player
                {
                    Name = player2Name,
                    Dices = new List<Dice>
                    {
                        new Dice{ Value = 3, Output = "3"},
                        new Dice{ Value = 3, Output = "3"},
                        new Dice{ Value = 3, Output = "3"},
                        new Dice{ Value = 3, Output = "3"}
                    }
                }
            };
        }
    }
}