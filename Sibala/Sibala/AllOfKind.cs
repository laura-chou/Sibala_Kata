using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class AllOfKind : ICompare
    {
        public string WinnerPoint { get; private set; }
        public string WinnerCategory => "all of a kind";

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

            var player1Point = player1Dices.First();
            var player2Point = player2Dices.First();

            var compareResult = diceOrder.IndexOf(player1Point.Value) - diceOrder.IndexOf(player2Point.Value);

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Point.Output : player2Point.Output;
            }

            return compareResult;
        }
    }
}