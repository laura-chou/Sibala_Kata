using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parser = new Parser();
            var players = parser.Parse(input);

            var player1Dices = players[0].Dices;
            var player2Dices = players[1].Dices;

            if (player1Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 2) == 1)
            {
                var comparer2 = new NormalPointComparer();
                var compareResult2 = comparer2.Compare(player1Dices, player2Dices);

                var winnerPlayer = compareResult2 > 0 ? players[0].Name : players[1].Name;
                var winnerCategory = comparer2.WinnerCategory;
                var winnerPoint = comparer2.WinnerPoint;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            var comparer = new AllOfKindComparer();
            int compareResult = comparer.Compare(player1Dices, player2Dices);
            
            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? players[0].Name : players[1].Name;
                var winnerCategory = comparer.WinnerCategory;
                var winnerPoint = comparer.WinnerPoint;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}
