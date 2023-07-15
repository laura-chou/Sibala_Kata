using Sibala.src.Categories;
using System.Collections.Generic;

namespace Sibala.src
{
    public interface IComparer
    {
        Category WinnerCategroy { get; }
        int Compare(Dices player1Dices, Dices player2Dices);
    }
}