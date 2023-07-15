namespace Sibala.src.Categories
{
    public class NoPoint : Category
    {
        public override string Name { get; }

        public override string Output { get; }

        public override CategoryType Type => CategoryType.NoPoint;
    }
}