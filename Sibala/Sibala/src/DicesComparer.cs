using Sibala.src.Categories;
using System.Collections.Generic;

namespace Sibala.src
{
    public class DicesComparer : IComparer
    {
        public Category WinnerCategroy { get; private set; }
        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            IComparer comparer;

            if (player1Dices.GetCategory().Type != player2Dices.GetCategory().Type)
            {
                comparer = new DifferentCategoryComparer();
            }
            else
            {
                var categoryComparerLookUp = new Dictionary<CategoryType, IComparer>
                {
                    { CategoryType.NormalPoint, new NormalPointComparer()},
                    { CategoryType.AllOfKind, new AllOfKindComparer()},
                    { CategoryType.NoPoint, new NoPointComparer()},
                };

                comparer = categoryComparerLookUp[player1Dices.GetCategory().Type];
            }

            var compareResult = comparer.Compare(player1Dices, player2Dices);

            if (compareResult != 0)
            {
                WinnerCategroy = compareResult > 0 ? player1Dices.GetCategory() : player2Dices.GetCategory();
            }
            return compareResult;
        }
    }
}