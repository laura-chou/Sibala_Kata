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
            var player1repeatDices = player1Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player1Point = player1Dices.Except(player1repeatDices).Sum(dice => dice.Value);

            var player2Dices = parse[1].Dices;
            var player2repeatDices = player2Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player2Point = player2Dices.Except(player2repeatDices).Sum(dice => dice.Value);

            var compareResult = player1Point - player2Point;

            var winnerPlayer = (compareResult > 0) ? parse[0].Name : parse[1].Name;
            var winnerCategory = "normal point";
            var winnerPoint = (compareResult > 0) ? player1Point : player2Point;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}