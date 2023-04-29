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

            return playerSection
                .Select(section => GetPlayer(section))
                .ToList();
        }

        private Player GetPlayer(string playerSection)
        {
            var playerName = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var playerDices = playerSection
                .Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(dice => new Dices
                {
                    Value = int.Parse(dice),
                    Output = dice
                })
                .ToList();

            return new Player
            {
                Name = playerName,
                Dices = new List<Dices>(playerDices)
            };
        }
    }
}