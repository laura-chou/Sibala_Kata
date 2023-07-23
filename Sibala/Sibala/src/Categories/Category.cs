namespace Sibala.src.Categories
{
    public abstract class Category
    {
        public string Description => $"{Name}: {Output}";
        public abstract string Name { get; }
        public abstract string Output { get; }
        public abstract CategoryType Type { get; }
    }
}