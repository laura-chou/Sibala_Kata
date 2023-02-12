using System;
using System.Collections.Generic;

namespace Sibala
{
    public class Parse
    {
        public List<Player> Parser(string input)
        {
            var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Name = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            return new List<Player>
            {
                new Player
                {
                    Name = player1Name,
                },
                new Player
                {
                    Name = "White",
                }
            };
        }
    }
}