using System;
using System.Collections.Generic;
using System.Text;

namespace Sibala
{
    internal interface ICompare
    {
        string WinnerCategory { get; }
        string WinnerPoint { get; }
        int Compare(List<Dices> player1Dices, List<Dices> player2Dices);
    }
}
