using FluentAssertions.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPointComparer : IComparer
    {
        public string WinnerCategory => "normal point";

        public string WinnerPoint { get; private set; }

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            var calDices1 = CalculateNormalPointDices(player1Dices);
            var calDices2 = CalculateNormalPointDices(player2Dices);

            var player1Point = calDices1.Sum(dice => dice.Value);
            var player2Point = calDices2.Sum(dice => dice.Value);

            var compareResult = player1Point - player2Point;

            if (compareResult == 0)
            {
                compareResult = calDices1.Max(dice => dice.Value) - calDices2.Max(dice => dice.Value);
            }

            if (compareResult != 0) 
            {
                WinnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compareResult;
        }

        private static IList<Dice> CalculateNormalPointDices(Dices playerDices)
        {
            var minRepeatDices = playerDices
                .GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();

            return playerDices.Except(minRepeatDices).ToList();
        }
    }
}