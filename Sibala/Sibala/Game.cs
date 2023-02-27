using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parse = new Parse();
            var player = parse.Parser(input);

            if (player[0].Dices.GroupBy(x => x.Value).Where(w => w.Count() > 3).Count() > 0 &&
                player[1].Dices.GroupBy(x => x.Value).Where(w => w.Count() > 3).Count() > 0 &&
                player[0].Dices.First().Value != player[1].Dices.First().Value)
            {
                var category = new AllOfKind(player[0], player[1]);
                return $"{category.Player} win. - with {category.Category}: {category.Point}";
            }

            return "Tie";
        }
    }
}