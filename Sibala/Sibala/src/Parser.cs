using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            var player1Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Name = player1Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Dices = player1Section
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dices {
                    Value = int.Parse(dice),
                    Output = dice
                })
                .ToList();

            var player2Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[1];
            var player2Name = player2Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Dices = player2Section
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dices
                {
                    Value = int.Parse(dice),
                    Output = dice
                })
                .ToList();

            return new List<Player>
            {
                new Player
                {
                    Name = player1Name,
                    Dices = new List<Dices>(player1Dices)
                },
                new Player
                {
                    Name = player2Name,
                    Dices = new List<Dices>(player2Dices)
                }
            };
        }
    }
}