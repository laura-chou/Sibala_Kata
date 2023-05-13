using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
            var player1Name = playerSection[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Dices = playerSection[0]
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dices
                {
                    Value = int.Parse(dice),
                    Output = dice
                })
                .ToList();
            
            var player2Name = playerSection[1].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Dices = playerSection[1]
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