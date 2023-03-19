using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class Parse
    {
        public List<Player> Parser(string input)
        {
            var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
            
            var player1Name = playerSection[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Dices = playerSection[0]
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => new Dice { Value = int.Parse(s), Output = s })
                .ToList();

            var player2Name = playerSection[1].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Dices = playerSection[1]
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => new Dice { Value = int.Parse(s), Output = s })
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
                    Name = player2Name,
                    Dices = new List<Dice>(player2Dices)
                }
            };
        }
    }
}