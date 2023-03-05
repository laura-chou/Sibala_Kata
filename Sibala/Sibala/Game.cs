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

            var player1Dice = parser[0].Dices.First().Value;
            var player2Dice = parser[1].Dices.First().Value;

            var winnerPlayer = (player1Dice > player2Dice) ? parser[0].Name : parser[1].Name;
            var winnerCategory = "all of a kind";
            var winnerPoint = (player1Dice > player2Dice) ? player1Dice : player2Dice;

            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}