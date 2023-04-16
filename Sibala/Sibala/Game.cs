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

            var winnerPlayer = player1Name;
            var winnerCategory = "normal point";
            var winnerPoint = player1Point;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}