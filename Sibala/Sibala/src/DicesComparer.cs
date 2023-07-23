using Sibala.src.Categories;
using System.Collections.Generic;

namespace Sibala.src
{
    public class DicesComparer : IComparer
    {
        public Category WinnerCategory { get; private set; }

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            IComparer comparer;
            
            var dice1CategoryType = player1Dices.GetCategory().Type;
            var dice2CategoryType = player2Dices.GetCategory().Type;
            
            if (dice1CategoryType != dice2CategoryType)
            {
                comparer = new DifferentCategoryComparer();
            }
            else
            {
                var categoryComparerMapper = new Dictionary<CategoryType, IComparer>
                {
                    { CategoryType.NormalPoint, new NormalPointComparer() },
                    { CategoryType.AllOfKind, new AllOfKindComparer() },
                    { CategoryType.NoPoint, new NoPointComparer() }
                };

                comparer = categoryComparerMapper[dice1CategoryType];
            }

            var compareResult = comparer.Compare(player1Dices, player2Dices);

            if (compareResult != 0)
            {
                WinnerCategory = compareResult > 0 ? player1Dices.GetCategory() : player2Dices.GetCategory();
            }

            return compareResult;
        }
    }
}