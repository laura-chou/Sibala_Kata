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

            return new List<Player>
            {
                GetPlayer(playerSections, 0),
                GetPlayer(playerSections, 1)
            };
        }

        private static Player GetPlayer(string[] playerSections, int index)
        {
            var playerName = playerSections[index].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];

            var playerDices = playerSections[index].Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dice
                {
                    Value = int.Parse(dice),
                    Output = dice
                })
                .ToList();

            return new Player
            {
                Name = playerName,
                Dices = playerDices
            };
        }
    }
}