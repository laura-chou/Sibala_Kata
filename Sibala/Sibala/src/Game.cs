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

            IComparer comparer;

            if (player1Dices.GetCategory().Type != player2Dices.GetCategory().Type)
            {
                comparer = new DifferentCategoryComparer();
            } 
            else
            {
                if (player1Dices.GetCategory().Type == CategoryType.NormalPoint)
                {
                    comparer = new NormalPointComparer();
                }
                else if (player1Dices.GetCategory().Type == CategoryType.AllOfKind)
                {
                    comparer = new AllOfKindComparer();
                }
                else
                {
                    comparer = new NoPointComparer();
                }
            }

            var compareResult = comparer.Compare(player1Dices, player2Dices);

            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? players[0].Name : players[1].Name;
                return $"{winnerPlayer} win. - with {comparer.WinnerCategroy.Description}";
            }

            return "Tie";
        }
    }
}