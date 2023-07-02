using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPointComparer : IComparer
    {
        public string WinnerCategory => "normal point";

        public string WinnerPoint { get; private set; }

        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            var player1Point = CalculateNormalPoint(player1Dices);
            var player2Point = CalculateNormalPoint(player2Dices);

            var compareResult = player1Point - player2Point;

            WinnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();

            return compareResult;
        }

        private static int CalculateNormalPoint(List<Dice> playerDices)
        {
            var minRepeatDices = playerDices
                .GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();

            return playerDices.Except(minRepeatDices).Sum(dice => dice.Value);
        }
    }
}