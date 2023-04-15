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

            var playerList = new List<Player>();

            foreach (var player in playerSection)
            {
                var playerName = player.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
                var playerDices = player.Split(":", StringSplitOptions.RemoveEmptyEntries)[1]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(dice => new Dices
                    {
                        Value = int.Parse(dice),
                        Output = dice
                    })
                    .ToList();

                playerList.Add(new Player
                {
                    Name = playerName,
                    Dices = playerDices
                });
            }

            return playerList;
        }
    }
}