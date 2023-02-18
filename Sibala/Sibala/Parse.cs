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

            return new List<Player>
            {
                GetPlayer(playerSection[0]),
                GetPlayer(playerSection[1])
            };
        }

        private Player GetPlayer(string playerSection)
        {
            var playerName = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var playerDices = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => new Dice { Value = int.Parse(s) })
                .ToList();
            var player = new Player
            {
                Name = playerName,
                Dices = new List<Dice>(playerDices)
            };
            return player;
        }
    }
}