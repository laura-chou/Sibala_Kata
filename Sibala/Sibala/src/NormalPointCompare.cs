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
            var player1RepeatDices = GetRepeatDices(player1Dices);
            var player2RepeatDices = GetRepeatDices(player2Dices);

            var player1Point = GetPlayerPoint(player1Dices, player1RepeatDices);
            var player2Point = GetPlayerPoint(player2Dices, player2RepeatDices);

            var compare = player1Point - player2Point;

            if (compare == 0)
            {
                var maxDice1 = GetMaxDice(player1Dices, player1RepeatDices);
                var maxDice2 = GetMaxDice(player2Dices, player2RepeatDices);

                compare = maxDice1 - maxDice2;
            }

            WinnerPoint = compare > 0 ? player1Point.ToString() : player2Point.ToString();

            return compare;
        }

        private int GetMaxDice(List<Dices> playerDices, IGrouping<int, Dices> playerRepeatDices)
        {
            return playerDices.Except(playerRepeatDices).Max(dice => dice.Value);
        }

        private int GetPlayerPoint(List<Dices> playerDices, IGrouping<int, Dices> playerRepeatDices)
        {
            return playerRepeatDices == null ? 0 :
                playerDices.Except(playerRepeatDices).Sum(dice => dice.Value);
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