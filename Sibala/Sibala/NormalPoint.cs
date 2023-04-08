using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class NormalPoint
    {
        public string WinnerCategory => "normal point";
        public string WinnerPoint { get; set; }

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var repeatDices1 = player1Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var repeatDices2 = player2Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .First(dice => dice.Count() == 2)
                .ToList();

            var player1Point = player1Dices.Except(repeatDices1).Sum(dice => dice.Value);
            var player2Point = player2Dices.Except(repeatDices2).Sum(dice => dice.Value);

            var compareDice = player1Point - player2Point;

            if (compareDice != 0)
            {
                WinnerPoint = (compareDice > 0) ? player1Point.ToString() : player2Point.ToString();
            }

            return compareDice;
        }
    }
}