using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    internal class Category
    {
        public CategoryEnum DicesCategory { get; private set; }

        public Category(List<Dice> player1Dices, List<Dice> player2Dices)
        {
            if (player1Dices.GroupBy(x => x.Value).Where(w => w.Count() > 3).Count() > 0 &&
                player2Dices.GroupBy(x => x.Value).Where(w => w.Count() > 3).Count() > 0 &&
                player1Dices.First().Value != player2Dices.First().Value)
            {
                DicesCategory = CategoryEnum.AllOfKind;
            }
        }
    }
}