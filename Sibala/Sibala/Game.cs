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

            var player1Dice = parser[0].Dices.First().Value;
            var player2Dice = parser[1].Dices.First().Value;

            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };
            var compareDice = diceOrder.IndexOf(player1Dice) > diceOrder.IndexOf(player2Dice);
            
            if (player1Dice != player2Dice)
            {
                var winnerPlayer = compareDice ? parser[0].Name : parser[1].Name;
                var winnerCategory = "all of a kind";
                var winnerPoint = compareDice ? player1Dice : player2Dice;

                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}