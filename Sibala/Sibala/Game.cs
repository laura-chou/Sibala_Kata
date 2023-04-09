using NUnit.Framework;
using System;
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

            var player1Name = parser[0].Name;
            var player2Name = parser[1].Name;
            var player1Dices = parser[0].Dices;
            var player2Dices = parser[1].Dices;

            ICompare compare;

            compare = new NormalPoint();

            if (player1Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 4) > 0 ||
                player2Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 4) > 0)
            {
                compare = new AllOfKind();
            }

            var compareResult = compare.Compare(player1Dices, player2Dices);

            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? player1Name : player2Name;
                var winnerCategory = compare.WinnerCategory;
                var winnerPoint = compare.WinnerPoint;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}