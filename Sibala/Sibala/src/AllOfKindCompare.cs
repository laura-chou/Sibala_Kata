using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKindCompare : ICompare
    {
        public string WinnerCategory => "all of a kind";
        public string WinnerPoint { get; private set; }

        public int CompareDice(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var player1Point = player1Dices.First();
            var player2Point = player2Dices.First();

            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

            var compare = diceOrder.IndexOf(player1Point.Value) - diceOrder.IndexOf(player2Point.Value);
        
            if (compare != 0)
            {
                WinnerPoint = compare > 0 ? player1Point.Output : player2Point.Output;
            }

            return compare;
        }
    }
}