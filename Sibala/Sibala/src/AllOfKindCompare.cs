using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKindCompare
    {
        public string WinnerCategory => "all of a kind";
        public string WinnerPoint { get; private set; }

        public int CompareDice(List<Dices> dices1, List<Dices> dices2)
        {
            var player1Point = dices1.First();
            var player2Point = dices2.First();

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