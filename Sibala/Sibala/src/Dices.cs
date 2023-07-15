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

        public IEnumerator<Dice> GetEnumerator()
        {
            return _dice.GetEnumerator();
        }

        public Category GetCategory()
        {
            if (IsAllOfKind())
            {
                return new AllOfKind(this);
            }

            if (IsNormalPoint())
            {
                return new NormalPoint(this);
            }

            return new NoPoint();
        }

        private bool IsNormalPoint()
        {
            return DiceGrouping
                            .Count(dice => dice.Count() == 2) >= 1;
        }

        private bool IsAllOfKind()
        {
            return DiceGrouping
                            .Count(dice => dice.Count() == 4) == 1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}