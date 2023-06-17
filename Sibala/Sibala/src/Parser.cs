using System;
using System.Collections.Generic;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            var playerSections = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
            var player1Name = playerSections[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Name = playerSections[1].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            return new List<Player>
            {
                new Player
                {
                    Name = player1Name
                },
                new Player
                {
                    Name = player2Name
                }
            };
        }
    }
}