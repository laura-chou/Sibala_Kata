using System.Linq;

namespace Sibala.src.Categories
{
    public class AllOfKind : Category
    {
        public AllOfKind(Dices dices) 
        {
            Output = dices.First().Output;
        }

        public override string Name => "all of a kind";

        public override string Output { get; }

        public override CategoryType Type => CategoryType.AllOfKind;
    }
}