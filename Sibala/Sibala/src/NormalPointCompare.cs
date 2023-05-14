using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPointCompare
    {
        public string WinnerCategory => "normal point";
        public string WinnerPoint { get; private set; }

        public int CompareDice(List<Dices> dices1, List<Dices> dices2)
        {
            var player1RepeatDices = dices1.GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();
            var player2RepeatDices = dices2.GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();

            var player1Point = dices1.Except(player1RepeatDices).Sum(dice => dice.Value);
            var player2Point = dices2.Except(player2RepeatDices).Sum(dice => dice.Value);

            var compare = player1Point - player2Point;

            if (compare != 0)
            {
                WinnerPoint = compare > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compare;
        }
    }
}