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

            int compareResult;
            string winnerCategory;
            string winnerPoint;

            if (player1Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 2) == 1)
            {
                var comparer2 = new NormalPointComparer();
                compareResult = comparer2.Compare(player1Dices, player2Dices);
                winnerCategory = comparer2.WinnerCategory;
                winnerPoint = comparer2.WinnerPoint;
            }
            else
            {
                var comparer = new AllOfKindComparer();
                compareResult = comparer.Compare(player1Dices, player2Dices);
                winnerCategory = comparer.WinnerCategory;
                winnerPoint = comparer.WinnerPoint;
            }
            
            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? players[0].Name : players[1].Name;
                
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}
