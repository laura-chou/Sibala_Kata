using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class Game
    {

        public string ShowResult(string input)
        {
            var parse = new Parse();
            var parser = parse.Parser(input);

            var player1Point = parser[0].Dices.First();
            var player2Point = parser[1].Dices.First();

            var comparePoint = player1Point.Value - player2Point.Value;

            if (comparePoint != 0)
            {
                var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

                var winnerPlayer = diceOrder.IndexOf(player1Point.Value) > diceOrder.IndexOf(player2Point.Value) ? parser[0].Name : parser[1].Name;
                var winnerCategory = "all of a kind";
                var winnerPoint = diceOrder.IndexOf(player1Point.Value) > diceOrder.IndexOf(player2Point.Value) ? player1Point.Output : player2Point.Output;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}