using System;
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
            var player1Dices = parser[0].Dices;
            var repeatDices1 = player1Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player1Point = player1Dices
                .Except(repeatDices1)
                .Sum(dice=> dice.Value);

            var player2Name = parser[1].Name;
            var player2Dices = parser[1].Dices;
            var repeatDices2 = player2Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player2Point = player2Dices
                .Except(repeatDices2)
                .Sum(dice => dice.Value);

            var compareResult = player1Point - player2Point;

            var winnerPlayer = compareResult > 0 ? player1Name : player2Name;
            var winnerCategory = "normal point";
            var winnerPoint = compareResult > 0 ? player1Point : player2Point;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}