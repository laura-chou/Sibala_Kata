using System;
using System.Linq;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parse = new Parse();
            var player = parse.Parser(input);

            var player1Point = player[0].Dices.First().Value;
            var player2Point = player[1].Dices.First().Value;

            var winnerPlayer = (player1Point > player2Point) ? player[0].Name : player[1].Name;
            var winnerCategory = "all of a kind";
            var winnerPoints = (player1Point > player2Point) ? player1Point : player2Point;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoints}";
        }
    }
}