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

            var player1Name = parser[0].Name;
            var player2Name = parser[1].Name;
            var player1Dices = parser[0].Dices;
            var player2Dices = parser[1].Dices;

            if (player1Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 2) > 0)
            {
                var category1 = new NormalPoint();
                var compare1 = category1.Compare(player1Dices, player2Dices);

                if (compare1 != 0)
                {
                    var winnerPlayer = compare1 > 0 ? player1Name : player2Name;
                    var winnerCategory = category1.WinnerCategory;
                    var winnerPoint = category1.WinnerPoint;
                    return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
                }
            }

            var category = new AllOfKind();
            var compare = category.Compare(player1Dices, player2Dices);

            if (compare != 0)
            {
                var winnerPlayer = compare > 0 ? player1Name : player2Name;
                var winnerCategory = category.WinnerCategory;
                var winnerPoint = category.WinnerPoint;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}