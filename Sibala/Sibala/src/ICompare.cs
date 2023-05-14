using System.Collections.Generic;

namespace Sibala.src
{
    public interface ICompare
    {
        string WinnerCategory { get; }
        string WinnerPoint { get; }
        int CompareDice(List<Dices> player1Dices, List<Dices> player2Dices);
    }
}