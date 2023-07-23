using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parser = new Parser();
            var players = parser.Parse(input);

            var player1Dices = players[0].Dices;
            var player2Dices = players[1].Dices;

            var dice1CategoryType = player1Dices.GetCategory().Type;
            var dice2CategoryType = player2Dices.GetCategory().Type;

            IComparer comparer;

            if (dice1CategoryType != dice2CategoryType)
            {
                comparer = new DifferentCategoryComparer();
            }
            else
            {
                var categoryComparerMapper = new Dictionary<CategoryType, IComparer>
                {
                    { CategoryType.NormalPoint, new NormalPointComparer() },
                    { CategoryType.AllOfKind, new AllOfKindComparer() },
                    { CategoryType.NoPoint, new NoPointComparer() }
                };

                comparer = categoryComparerMapper[dice1CategoryType];
            }
            

            var compareResult = comparer.Compare(player1Dices, player2Dices);

            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? players[0].Name : players[1].Name;
                return $"{winnerPlayer} win. - with {comparer.WinnerCategory.Description}";
            }

            return "Tie";
        }
    }
}
