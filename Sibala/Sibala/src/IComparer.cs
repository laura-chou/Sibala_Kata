using Sibala.src.Categories;
using System.Collections.Generic;

namespace Sibala.src
{
    public interface IComparer
    {
        Category WinnerCategory { get; }
        int Compare(Dices player1Dices, Dices player2Dices);
    }
}