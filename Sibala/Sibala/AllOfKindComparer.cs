using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class AllOfKindComparer : IComparer
    {
        public string WinnerPoint { get; set; }
        public string WinnerCategory => "all of a kind";

        public int Compare(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            var dice1 = player1Dices.First();
            var dice2 = player2Dices.First();
            
            var diceOrder = new List<int> { 2, 3, 5, 6, 4, 1 };
            var order1 = diceOrder.IndexOf(dice1.Value);
            var order2 = diceOrder.IndexOf(dice2.Value);

            var compareDice = order1 - order2;

            if (compareDice != 0)
            {
                WinnerPoint = (compareDice > 0) ? dice1.Output : dice2.Output;
            }

            return compareDice;
        }
    }
}