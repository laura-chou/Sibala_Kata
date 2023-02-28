using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    internal class Category
    {
        public CategoryEnum DicesCategory { get; private set; }

        public Category(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            if (player1Dices.GroupBy(g=>g.Value).Distinct().Count() == 1 &&
                player2Dices.GroupBy(g => g.Value).Distinct().Count() == 1 &&
                player1Dices.First().Value != player2Dices.First().Value)
            {
                DicesCategory = CategoryEnum.AllOfKind;
            }
        }
    }
}