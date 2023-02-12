using System;
using System.Collections.Generic;

namespace Sibala
{
    public class Parse
    {
        public List<Player> Parser(string v)
        {
            return new List<Player>
            {
                new Player
                {
                    Name = "Black",
                },
                new Player
                {
                    Name = "White",
                }
            };
        }
    }
}