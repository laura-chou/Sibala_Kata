using System;
using System.Linq;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parser = new Parser();
            var parse = parser.Parse(input);

            var player1Dices = parse[0].Dices;
            var player2Dices = parse[1].Dices;
            
            if (player1Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 4) > 0)
            {
                return "Black win. - with all of a kind: 6";
            }

            var compare = new NormalPoint();
            var compareResult = compare.Compare(player1Dices, player2Dices);

            if (compareResult != 0)
            {
                var winnerPlayer = (compareResult > 0) ? parse[0].Name : parse[1].Name;
                var winnerCategory = compare.WinnerCategory;
                var winnerPoint = compare.WinnerPoint;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}