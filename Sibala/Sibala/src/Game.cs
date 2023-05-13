using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parser = new Parser();
            var parse = parser.Parse(input);

            var player1Point = parse[0].Dices.First();
            var player2Point = parse[1].Dices.First();

            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

            var compare = diceOrder.IndexOf(player1Point.Value) - diceOrder.IndexOf(player2Point.Value);

            if (compare != 0)
            {
                var winnerPlayer = compare > 0 ? parse[0].Name : parse[1].Name;
                var winnerCategory = "all of a kind";
                var winnerPoint = compare > 0 ? player1Point.Output : player2Point.Output;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}