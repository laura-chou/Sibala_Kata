namespace Sibala.src
{
    internal class DifferentCategoryComparer : IComparer
    {
        public string WinnerCategory { get; private set; }

        public string WinnerPoint { get; private set; }

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            WinnerCategory = player1Dices.GetCategory().Name; 
            WinnerPoint = "6";

            return 1;
        }
    }
}