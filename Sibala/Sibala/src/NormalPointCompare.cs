using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPointCompare : ICompare
    {
        public string WinnerCategory => "normal point";
        public string WinnerPoint { get; private set; }

        public int CompareDice(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var player1RepeatDices = player1Dices.GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player2RepeatDices = player2Dices.GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();

            var player1Point = player1Dices.Except(player1RepeatDices).Sum(dice => dice.Value);
            var player2Point = player2Dices.Except(player2RepeatDices).Sum(dice => dice.Value);

            var compare = player1Point - player2Point;

            if (compare != 0)
            {
                WinnerPoint = compare > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compare;
        }
    }
}