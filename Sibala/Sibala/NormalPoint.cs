﻿using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class NormalPoint : ICompare
    {
        public string WinnerPoint { get; set; }
        public string WinnerCategory => "normal point";

        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            var repeatDices1 = player1Dices.GroupBy(g => g.Value).OrderBy(o => o.Key).First(f => f.Count() == 2).ToList();
            var repeatDices2 = player2Dices.GroupBy(g => g.Value).OrderBy(o => o.Key).First(f => f.Count() == 2).ToList();

            var player1Point = player1Dices.Except(repeatDices1).Sum(s => s.Value);
            var player2Point = player2Dices.Except(repeatDices2).Sum(s => s.Value);
            
            var compareDice = player1Point - player2Point;

            if (player1Point == player2Point)
            {
                var player1MaxPoint = player1Dices.Except(repeatDices1).Max(m => m.Value);
                var player2MaxPoint = player2Dices.Except(repeatDices2).Max(m => m.Value);

                compareDice = player1MaxPoint - player2MaxPoint;
            }

            if (compareDice != 0)
            {
                WinnerPoint = (compareDice > 0) ? player1Point.ToString() : player2Point.ToString();
            }

            return compareDice;
        }
    }
}