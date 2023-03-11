using System;
using System.Collections.Generic;
using System.Text;

namespace Sibala
{
    internal interface IComparer
    {
        int Compare(List<Dice> player1Dices, List<Dice> player2Dices);
        string WinnerPoint { get; }
        string WinnerCategory { get; }
    }
}
