using System.Collections.Generic;

namespace Sibala.src
{
    public interface IComparer
    {
        string WinnerCategory { get; }
        string WinnerPoint { get; }
        int Compare(List<Dice> player1Dices, List<Dice> player2Dices);
    }
}