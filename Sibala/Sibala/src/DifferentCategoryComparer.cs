using Sibala.src.Categories;

namespace Sibala.src
{
    internal class DifferentCategoryComparer : IComparer
    {
        public string WinnerCategory { get; private set; }

        public string WinnerPoint { get; private set; }
        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            var category1 = player1Dices.GetCategory();
            var category2 = player2Dices.GetCategory();

            var compareResult = category1.Type - category2.Type;

            if (compareResult != 0)
            {
                var winnerCategory = compareResult > 0 ? category1 : category2;
                WinnerCategory = winnerCategory.Name;
                WinnerPoint = winnerCategory.Output;
            }

            return compareResult;

        }
    }
}