using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class AllOfKindComparer
    {
        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices, out string winnerPoint)
        {
            var compareResult = player1Dices.First().Value - player2Dices.First().Value;
            winnerPoint = string.Empty;
            if (compareResult != 0)
            {
                winnerPoint = compareResult > 0 ? player1Dices.First().Output : player2Dices.First().Output;
            }
            return compareResult;
        }
    }
}