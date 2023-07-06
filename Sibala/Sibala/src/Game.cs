using System;
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

            var dice1CategoryType = player1Dices.GetDicesCategoryType();
            var dice2CategoryType = player2Dices.GetDicesCategoryType();

            IComparer comparer;

            if (dice1CategoryType != dice2CategoryType)
            {
                comparer = new DifferentCategoryComparer();
            } else
            {
                if (dice1CategoryType == CategoryType.NormalPoint)
                {
                    comparer = new NormalPointComparer();
                }
                else
                {
                    comparer = new AllOfKindComparer();
                }
            }

            var compareResult = comparer.Compare(player1Dices, player2Dices);

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