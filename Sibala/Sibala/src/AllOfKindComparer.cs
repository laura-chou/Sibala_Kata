using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKindComparer
    {
        public string WinnerCategory => "all of a kind";

        public string WinnerPoint { get; private set; }

        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

            var compareResult = diceOrder.IndexOf(player1Dices.First().Value)
                - diceOrder.IndexOf(player2Dices.First().Value);

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Dices.First().Output : player2Dices.First().Output;
            }
            return compareResult;
        }
    }
}