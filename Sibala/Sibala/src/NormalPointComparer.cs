using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPointComparer
    {

        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices, out string winnerPoint)
        {
            var repeatDices1 = player1Dices
                .GroupBy(dices => dices.Value)
                .First(dice => dice.Count() == 2)
                .ToList();
            var repeatDices2 = player2Dices
                .GroupBy(dices => dices.Value)
                .First(dice => dice.Count() == 2)
                .ToList();

            var player1Point = player1Dices.Except(repeatDices1).Sum(dice => dice.Value);
            var player2Point = player2Dices.Except(repeatDices2).Sum(dice => dice.Value);

            var compareResult = player1Point - player2Point;

            winnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();

            return compareResult;
        }
    }
}