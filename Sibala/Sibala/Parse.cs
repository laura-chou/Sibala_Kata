﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Sibala
{
    internal class Parse
    {
        public List<Player> Parser(string input)
        {
            var player1Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
            var player1Name = player1Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
            var player2Section = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[1];
            var player2Name = player2Section.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];

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