using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            var playerSections = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
            var player1Name = playerSections[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Name = playerSections[1].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Dices = playerSections[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dice
                { 
                    Value=int.Parse(dice),
                    Output=dice 
                })
                .ToList();
            var player2Dices = playerSections[1].Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dice
                { 
                    Value = int.Parse(dice),
                    Output = dice 
                })
                .ToList();

            var player1 = new Player
            {
                Name = player1Name,
                Dices = player1Dices
            };

            var player2 = new Player
            {
                Name = player2Name,
                Dices = player2Dices
            };

            return new List<Player>
            {
                player1,
                player2
            };
        }
    }
}