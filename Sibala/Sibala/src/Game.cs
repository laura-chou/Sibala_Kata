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

            var winnerPlayer = parse[0].Name;
            var winnerCategory = "normal point";
            var winnerPoint = player1Point;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}