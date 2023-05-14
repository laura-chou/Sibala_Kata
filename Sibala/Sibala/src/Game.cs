﻿using NUnit.Framework;
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
            var parse = parser.Parse(input);

            if (parse[0].Dices.GroupBy(dices => dices.Value).Count(dice => dice.Count() == 2) > 0)
            {
                var compare1 = new NormalPointCompare();
                var compareResult1 = compare1.CompareDice(parse[0].Dices, parse[1].Dices);

                if (compareResult1 != 0)
                {
                    var winnerPlayer = compareResult1 > 0 ? parse[0].Name : parse[1].Name;
                    var winnerCategory = compare1.WinnerCategory;
                    var winnerPoint = compare1.WinnerPoint;
                    return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
                }
            }

            var compare = new AllOfKindCompare();
            var compareResult = compare.CompareDice(parse[0].Dices, parse[1].Dices);
            
            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? parse[0].Name : parse[1].Name;
                var winnerCategory = compare.WinnerCategory;
                var winnerPoint = compare.WinnerPoint;
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}