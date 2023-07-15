using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sibala.src.Categories;

namespace Sibala.src
{
    public class Dices : IEnumerable<Dice>
    {
        private readonly List<Dice> _dice;

        public Dices(List<Dice> dice)
        {
            _dice = dice;
        }

        private List<IGrouping<int, Dice>> DiceGrouping => this.GroupBy(dices => dices.Value).ToList();
        
        public IList<Dice> CalculateNormalPointDices()
        {
            var minRepeatDices = DiceGrouping
                .OrderBy(dices => dices.Key)
                .First(dice => dice.Count() == 2)
                .ToList();

            return this.Except(minRepeatDices).ToList();
        }

        public CategoryType GetDicesCategoryType()
        {
            return GetCategory().Type;
        }

        public IEnumerator<Dice> GetEnumerator()
        {
            return _dice.GetEnumerator();
        }

        public Category GetCategory()
        {
            if (DiceGrouping
                .Count(dice => dice.Count() == 4) == 1)
            {
                return new AllOfKind(this);
            }

            if (DiceGrouping
                .Count(dice => dice.Count() == 2) >= 1)
            {
                return new NormalPoint(this);
            }

            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}