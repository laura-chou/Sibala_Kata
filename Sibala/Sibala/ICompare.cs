using System.Collections.Generic;

namespace Sibala
{
    internal interface ICompare
    {
        string WinnerPoint { get; }
        string WinnerCategory { get; }
        int Compare(List<Dices> player1Dices, List<Dices> player2Dices);
    }
}