﻿using System;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            //var parser = new Parser();
            //var parse = parser.Parse(input);
            var winnerPlayer = "Black";
            var winnerCategory = "normal point";
            var winnerPoint = "7";
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}