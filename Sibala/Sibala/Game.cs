﻿
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parse = new Parse();
            var parser = parse.Parser(input);

            var player1Dices = parser[0].Dices;
            var player2Dices = parser[1].Dices;

            var compare = new AllOfKind();
            var compareResult  = compare.Compare(player1Dices, player2Dices);
            

            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? parser[0].Name : parser[1].Name;
                var winnerCategory = compare.WinnerCategory;
                var winnerPoint = compare.WinnerPoint;

                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
            
        }
    }
}