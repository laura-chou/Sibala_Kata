using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKindComparer : IComparer
    {
        public string WinnerCategory => "all of a kind";

        public string WinnerPoint { get; private set; }

        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

            var dicePoint1 = player1Dices.First();
            var dicePoint2 = player2Dices.First();

            var compareResult = diceOrder.IndexOf(dicePoint1.Value)
                                - diceOrder.IndexOf(dicePoint2.Value);

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? dicePoint1.Output : dicePoint2.Output;
            }
            return compareResult;
        }
    }
}