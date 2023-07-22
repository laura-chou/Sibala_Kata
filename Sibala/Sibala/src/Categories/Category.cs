﻿namespace Sibala.src.Categories
{
    public abstract class Category
    {
        public abstract string Name { get; }
        public abstract string Output { get; }
        public abstract CategoryType Type { get; }
    }
}