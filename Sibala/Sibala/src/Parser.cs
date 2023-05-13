using System;
using System.Collections.Generic;

namespace Sibala.src
{
    public class Parser
    {
        public List<Player> Parse(string input)
        {
            return new List<Player>
            {
                new Player
                {
                    Name = "Black"
                },
                new Player
                {
                    Name = "White"
                }
            };
        }
    }
}