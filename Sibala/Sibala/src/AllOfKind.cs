using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKind : ICompare
    {
        public string WinnerCategory => "all of a kind";
        public string WinnerPoint { get; private set; }

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var player1Point = player1Dices.First();
            var player2Point = player2Dices.First();

            var compareResult = player1Point.Value - player2Point.Value;

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Point.Output : player2Point.Output;
            }

            return compareResult;
        }
    }
}