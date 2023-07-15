using Sibala.src.Categories;

namespace Sibala.src
{
    public class NoPointComparer : IComparer
    {
        public Category WinnerCategroy => new NoPoint();

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            return 0;
        }
    }
}