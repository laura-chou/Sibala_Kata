using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class NormalPoint : ICompare
    {
        public string WinnerCategory => "normal point";
        public string WinnerPoint { get; set; }

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var repeatDices1 = player1Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .FirstOrDefault(dice => dice.Count() == 2);
            var repeatDices2 = player2Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .FirstOrDefault(dice => dice.Count() == 2);

            var player1Point = 0;
            var player2Point = 0;
            if (repeatDices1 != null)
            {
                player1Point = player1Dices.Except(repeatDices1).Sum(dice => dice.Value);
            }
            if (repeatDices2 != null)
            {
                player2Point = player2Dices.Except(repeatDices2).Sum(dice => dice.Value);
            }

            var compareDice = player1Point - player2Point;

            if (player1Point == player2Point)
            {
                var maxDice1 = player1Dices.Except(repeatDices1).Max(dice => dice.Value);
                var maxDice2 = player2Dices.Except(repeatDices2).Max(dice => dice.Value);

                compareDice = maxDice1 - maxDice2;
            }

            if (compareDice != 0)
            {
                WinnerPoint = (compareDice > 0) ? player1Point.ToString() : player2Point.ToString();
            }

            return compareDice;
        }
    }
}