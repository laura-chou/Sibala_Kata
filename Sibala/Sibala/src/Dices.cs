using System.Collections;
using System.Collections.Generic;

namespace Sibala.src
{
    internal class Dices : IEnumerable<Dice>
    {
        private readonly List<Dice> _dice;

        public Dices(List<Dice> dice)
        {
            _dice = dice;
        }

        public IEnumerator<Dice> GetEnumerator()
        {
            return _dice.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}