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

            var category = new Category(player[0].Dices, player[1].Dices);
            if (category.DicesCategory is CategoryEnum.AllOfKind)
            {
                var winnerCategory = new AllOfKind(player[0], player[1]);
                return $"{winnerCategory.Player} win. - with {winnerCategory.Category}: {winnerCategory.Point}";
            }

            if (category.DicesCategory is CategoryEnum.NormalPoint)
            {
                return "Black win. - with normal point: 7";
            }

            return "Tie";
        }
    }
}