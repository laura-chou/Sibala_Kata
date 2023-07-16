using System.Collections.Generic;

namespace Sibala.src
{
    public interface IComparer
    {
        string WinnerCategory { get; }
        string WinnerPoint { get; }
        int Compare(Dices player1Dices, Dices player2Dices);
    }
}