using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class NormalPoint : ICompare
    {
        public string WinnerCategory => "normal point";

        public string WinnerPoint { get; private set; }

        public int Compare(List<Dices> player1Dices, List<Dices> player2Dices)
        {
            var player1repeatDices = GetRepeatDices(player1Dices);
            var player1Point = GetPlayerPoint(player1Dices, player1repeatDices);

            var player2repeatDices = GetRepeatDices(player2Dices);
            var player2Point = GetPlayerPoint(player2Dices, player2repeatDices);

            var compareResult = player1Point - player2Point;

            if (player1Point == player2Point && player1Point != 0)
            {
                var player1MaxDice = player1Dices.Except(player1repeatDices).Max(dice => dice.Value);
                var player2MaxDice = player2Dices.Except(player2repeatDices).Max(dice => dice.Value);

                compareResult = player1MaxDice - player2MaxDice;
            }

            if (compareResult != 0)
            {
                WinnerPoint = compareResult > 0 ? player1Point.ToString() : player2Point.ToString();
            }

            return compareResult;
        }

        private int GetPlayerPoint(List<Dices> playerDices, List<Dices> playerRepeatDices)
        {
            return playerRepeatDices.Count == 0 ? 0 :
                playerDices.Except(playerRepeatDices).Sum(dice => dice.Value);
        }

        private List<Dices> GetRepeatDices(List<Dices> player1Dices)
        {
            var repeatDices = player1Dices
                .GroupBy(dices => dices.Value)
                .OrderBy(dices => dices.Key)
                .FirstOrDefault(dice => dice.Count() == 2);

            return repeatDices == null ? new List<Dices>() : repeatDices.ToList();
        }
    }
}