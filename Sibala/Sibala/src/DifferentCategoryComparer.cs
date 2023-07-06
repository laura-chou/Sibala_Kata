namespace Sibala.src
{
    internal class DifferentCategoryComparer : IComparer
    {
        public string WinnerCategory { get; private set; }

        public string WinnerPoint { get; private set; }

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            var category = player1Dices.GetCategory();
            WinnerCategory = category.Name; 
            WinnerPoint = category.Output;

            return 1;
        }
    }
}