using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class AllOfKind
    {
        public string WinnerPoint { get; private set; }
        public string WinnerCategory => "all of a kind";

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var player1Point = player1Dices.First().Value;
            var player2Point = player2Dices.First().Value;

            var compareResult = player1Point - player2Point;

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compareResult;
        }
    }
}