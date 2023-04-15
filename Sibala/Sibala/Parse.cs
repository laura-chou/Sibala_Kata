using NUnit.Framework;
using System;
using System.Collections.Generic;

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

                playerList.Add(new Player
                {
                    Name = playerName
                });
            }

            return playerList;
        }
    }
}