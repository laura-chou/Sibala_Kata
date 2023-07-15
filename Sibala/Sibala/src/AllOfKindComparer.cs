using Sibala.src.Categories;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKindComparer : IComparer
    {
        public Category WinnerCategroy { get; private set; }

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };

            var dicePoint1 = player1Dices.First();
            var dicePoint2 = player2Dices.First();

            var compareResult = diceOrder.IndexOf(dicePoint1.Value)
                                - diceOrder.IndexOf(dicePoint2.Value);

            if (compareResult != 0)
            {
                WinnerCategroy = new AllOfKind(compareResult > 0 ? player1Dices : player2Dices);
            }
            return compareResult;
        }
    }
}