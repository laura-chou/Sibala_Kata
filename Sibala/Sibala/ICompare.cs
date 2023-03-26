using System.Collections.Generic;

namespace Sibala
{
    internal interface ICompare
    {
        string WinnerPoint { get; }
        string WinnerCategory { get; }

        int Compare(List<Dice> player1Dices, List<Dice> player2Dices);
    }
}