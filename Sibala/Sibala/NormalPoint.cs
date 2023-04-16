using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class NormalPoint
    {
        public string WinnerPoint { get; private set; }
        public string WinnerCategory => "normal point";

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var repeatDices1 = player1Dices
                 .GroupBy(dices => dices.Value)
                 .OrderBy(dice => dice.Key)
                 .First(dice => dice.Count() == 2)
                 .ToList();
            var player1Point = player1Dices
                .Except(repeatDices1)
                .Sum(dice => dice.Value);

            var repeatDices2 = player2Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dice => dice.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player2Point = player2Dices
                .Except(repeatDices2)
                .Sum(dice => dice.Value);

            var compareResult = player1Point - player2Point;

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compareResult;
        }
    }
}