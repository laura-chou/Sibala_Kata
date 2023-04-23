using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class NormalPoint : ICompare
    {
        public string WinnerPoint { get; private set; }
        public string WinnerCategory => "normal point";

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var repeatDices1 = GetRepeatDice(player1Dices);
            var player1Point = GetPlayerPoint(player1Dices, repeatDices1);

            var repeatDices2 = GetRepeatDice(player2Dices);
            var player2Point = GetPlayerPoint(player2Dices, repeatDices2);

            var compareResult = player1Point - player2Point;

            if (player1Point == player2Point)
            {
                var maxDice1 = player1Dices.Except(repeatDices1).Max(dice => dice.Value);
                var maxDice2 = player2Dices.Except(repeatDices2).Max(dice => dice.Value);

                compareResult = maxDice1 - maxDice2;
            }

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compareResult;
        }

        private int GetPlayerPoint(List<Dices> playerDices, IGrouping<int, Dices> repeatDices)
        {
            var playerPoint = 0;

            if (repeatDices != null)
            {
                playerPoint = playerDices.Except(repeatDices).Sum(dice => dice.Value);
            }

            return playerPoint;
        }

        private IGrouping<int, Dices> GetRepeatDice(List<Dices> playerDices)
        {
            return playerDices
                 .GroupBy(dices => dices.Value)
                 .OrderBy(dice => dice.Key)
                 .FirstOrDefault(dice => dice.Count() == 2);
        }
    }
}