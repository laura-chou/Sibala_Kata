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
            var player1Point = GetPlayerPoint(player1Dices);
            var player2Point = GetPlayerPoint(player2Dices);

            var compare = player1Point - player2Point;

            if (compare == 0)
            {
                var maxDice1 = GetMaxDice(player1Dices);
                var maxDice2 = GetMaxDice(player2Dices);

                compare = maxDice1 - maxDice2;
            }

            WinnerPoint = compare > 0 ? player1Point.ToString() : player2Point.ToString();

            return compare;
        }

        private int GetMaxDice(List<Dices> playerDices)
        {
            return playerDices.Except(GetRepeatDices(playerDices)).Max(dice => dice.Value);
        }

        private int GetPlayerPoint(List<Dices> playerDices)
        {
            var playerRepeatDice = GetRepeatDices(playerDices);

            return playerRepeatDice == null ? 0 :
                playerDices.Except(playerRepeatDice).Sum(dice => dice.Value);
        }

        private IGrouping<int, Dices> GetRepeatDices(List<Dices> playerDices)
        {
            return playerDices
                .GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .FirstOrDefault(dice => dice.Count() == 2);
        }
    }
}