using Sibala.src.Categories;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPointComparer : IComparer
    {
        public Category WinnerCategory { get; private set; }

        public int Compare(Dices player1Dices, Dices player2Dices)
        {
            var calDices1 = player1Dices.CalculateNormalPointDices();
            var calDices2 = player2Dices.CalculateNormalPointDices();

            var player1Point = calDices1.Sum(dice => dice.Value);
            var player2Point = calDices2.Sum(dice => dice.Value);

            var compareResult = player1Point - player2Point;

            if (compareResult == 0)
            {
                compareResult = calDices1.Max(dice => dice.Value) - calDices2.Max(dice => dice.Value);
            }

            if (compareResult != 0) 
            {
                WinnerCategory = new NormalPoint(compareResult > 0 ? player1Dices : player2Dices);
            }

            return compareResult;
        }
    }
}