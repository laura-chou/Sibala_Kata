using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    internal class Parse
    {
        public List<Player> Parser(string input)
        {
            var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);

            return playerSection
                .Select(s => GetPlayer(s))
                .ToList();
        }

        private Player GetPlayer(string playerSection)
        {
            var playerName = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var playerDices = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => new Dice { Value = int.Parse(s), Output = s })
                            .ToList();

            return new Player
            {
                Name = playerName,
                Dices = new List<Dice>(playerDices)
            };
        }
    }
}